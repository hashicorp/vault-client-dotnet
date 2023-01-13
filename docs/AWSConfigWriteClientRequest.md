# Vault.Model.AWSConfigWriteClientRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKey** | **string** | AWS Access Key ID for the account used to make AWS API requests. | [optional] [default to ""]
**AllowedStsHeaderValues** | **List&lt;string&gt;** | List of additional headers that are allowed to be in AWS STS request headers | [optional] 
**Endpoint** | **string** | URL to override the default generated endpoint for making AWS EC2 API calls. | [optional] [default to ""]
**IamEndpoint** | **string** | URL to override the default generated endpoint for making AWS IAM API calls. | [optional] [default to ""]
**IamServerIdHeaderValue** | **string** | Value to require in the X-Vault-AWS-IAM-Server-ID request header | [optional] [default to ""]
**MaxRetries** | **int** | Maximum number of retries for recoverable exceptions of AWS APIs | [optional] [default to -1]
**SecretKey** | **string** | AWS Secret Access Key for the account used to make AWS API requests. | [optional] [default to ""]
**StsEndpoint** | **string** | URL to override the default generated endpoint for making AWS STS API calls. | [optional] [default to ""]
**StsRegion** | **string** | The region ID for the sts_endpoint, if set. | [optional] [default to ""]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

