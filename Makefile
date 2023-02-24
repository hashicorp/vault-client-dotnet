OPENAPI_GENERATOR_VERSION ?= v5.4.0
OPENAPI_SPEC_PATH         ?= openapi.json
GENERATE_CONFIG_PATH      ?= generate/config.yaml
GENERATE_TEMPLATES_PATH   ?= generate/templates
OUTPUT_PATH               ?= .

.PHONY: delete-generated generate clean build build-prod regen

regen: delete-generated generate format clean

regen-bin: delete-generated generate format clean build

delete-generated:
	rm -rf \
		docs \
		build.bat \
		build.sh \
		git_push.sh \
		mono_nunit_test.sh \
		VaultClient.sln \
		.gitignore \
		.openapi-generator \
		.travis.yml

# --api-name-suffix does not allow empty strings; "REPLACE~ME" is a workaround
generate:
	docker run \
		--rm \
		--volume "${PWD}:/local" \
		--user="$(shell id -u):$(shell id -g)" \
			openapitools/openapi-generator-cli:$(OPENAPI_GENERATOR_VERSION) generate \
				--generator-name   csharp-netcore \
				--input-spec       /local/$(OPENAPI_SPEC_PATH) \
				--config           /local/$(GENERATE_CONFIG_PATH) \
				--template-dir     /local/$(GENERATE_TEMPLATES_PATH) \
				--output           /local/$(OUTPUT_PATH) \
				--api-name-suffix  "REPLACE~ME"

	rename --force 's/REPLACE~ME//g' docs/*.md
	rename --force 's/REPLACE~ME//g' src/Vault/Api/*.cs
	rename --force 's/REPLACE~ME//g' src/Vault.Test/Api/*.cs

	sed -i'.original' -e 's/REPLACE~ME//g' README.md
	sed -i'.original' -e 's/REPLACE~ME//g' docs/*.md
	sed -i'.original' -e 's/REPLACE~ME//g' src/Vault/*.cs
	sed -i'.original' -e 's/REPLACE~ME//g' src/Vault/Api/*.cs
	sed -i'.original' -e 's/REPLACE~ME//g' src/Vault/Client/*.cs
	sed -i'.original' -e 's/REPLACE~ME//g' src/Vault.Test/Api/*.cs

	rm -f *.original
	rm -f docs/*.original
	rm -f src/Vault/*.original
	rm -f src/Vault/Api/*.original
	rm -f src/Vault/Client/*.original
	rm -f src/Vault.Test/Api/*.original

clean:
	dotnet clean
	rm -rf \
		build.bat \
		build.sh \
		git_push.sh \
		mono_nunit_test.sh \
		.openapi-generator \
		.travis.yml

build:
	dotnet build

build-prod:
	dotnet build -c release

format:
	dotnet format
