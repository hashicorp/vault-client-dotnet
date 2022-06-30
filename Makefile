OPENAPI_GENERATOR_VERSION ?= v5.4.0
OPENAPI_SPEC_PATH         ?= openapi.json
GENERATE_CONFIG_PATH      ?= generate/config.yaml
GENERATE_TEMPLATES_PATH   ?= generate/templates
OUTPUT_PATH               ?= .

.PHONY: delete-generated generate clean build regen

regen: delete-generated generate clean

delete-generated:
	rm -rf \
		api \
		docs \
		src \
		gradle \
		build.gradle \
		build.sbt \
		git_push.sh \
		gradle.properties \
		gradlew \
		gradlew.bat \
		pom.xml \
		README.md \
		settings.gradle \
		.gitignore \
		.openapi-generator \
		.openapi-generator-ignore \
		.travis.yml

generate:
	docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:$(OPENAPI_GENERATOR_VERSION) generate \
			-g csharp \
			-i /local/$(OPENAPI_SPEC_PATH) \
			-c /local/$(GENERATE_CONFIG_PATH) \
			-t /local/$(GENERATE_TEMPLATES_PATH) \
			-o /local/$(OUTPUT_PATH)

clean:
	rm -rf \
		src/VaultClient/bin \
		src/VaultClient/obj \
		src/VaultClient.Test/bin \
		src/VaultClient.Test/obj \
		git_push.sh \
		.openapi-generator \
		.openapi-generator-ignore \
		.travis.yml

build:
	dotnet build
