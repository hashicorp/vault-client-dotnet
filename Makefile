OPENAPI_GENERATOR_VERSION ?= v5.4.0
OPENAPI_SPEC_PATH         ?= openapi.json
GENERATE_CONFIG_PATH      ?= generate/config.yaml
GENERATE_TEMPLATES_PATH   ?= generate/templates
OUTPUT_PATH               ?= .

.PHONY: delete-generated generate clean build build-prod regen

regen: delete-generated generate clean

delete-generated:
	rm -rf \
		docs \
		src \
		build.bat \
		build.sh \
		git_push.sh \
		mono_nunit_test.sh \
		VaultClient.sln \
		.gitignore \
		.openapi-generator \
		.openapi-generator-ignore \
		.travis.yml

generate:
	docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:$(OPENAPI_GENERATOR_VERSION) generate \
			-g csharp-netcore \
			-i /local/$(OPENAPI_SPEC_PATH) \
			-c /local/$(GENERATE_CONFIG_PATH) \
			-t /local/$(GENERATE_TEMPLATES_PATH) \
			-o /local/$(OUTPUT_PATH)

clean:
	dotnet clean
	rm -rf \
		build.bat \
		build.sh \
		git_push.sh \
		mono_nunit_test.sh \
		.openapi-generator \
		.openapi-generator-ignore \
		.travis.yml

build:
	dotnet build

build-prod:
	dotnet build -c release
