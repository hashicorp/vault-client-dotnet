# VaultClient.Model.RabbitmqConfigConnectionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionUri** | **string** | RabbitMQ Management URI | [optional] 
**Password** | **string** | Password of the provided RabbitMQ management user | [optional] 
**PasswordPolicy** | **string** | Name of the password policy to use to generate passwords for dynamic credentials. | [optional] 
**Username** | **string** | Username of a RabbitMQ management administrator | [optional] 
**UsernameTemplate** | **string** | Template describing how dynamic usernames are generated. | [optional] 
**VerifyConnection** | **bool** | If set, connection_uri is verified by actually connecting to the RabbitMQ management API | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

