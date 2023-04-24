OPENAPI_GENERATOR_VERSION ?= v6.4.0
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
		src/Vault/Model \
		src/Vault.Test/Model \
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
				--engine           "handlebars" \
				--input-spec       /local/$(OPENAPI_SPEC_PATH) \
				--config           /local/$(GENERATE_CONFIG_PATH) \
				--template-dir     /local/$(GENERATE_TEMPLATES_PATH) \
				--output           /local/$(OUTPUT_PATH) \

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

format-readme:
	prettier --write README.md

