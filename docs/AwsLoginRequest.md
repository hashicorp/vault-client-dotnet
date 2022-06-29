# VaultClient.Model.AwsLoginRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IamHttpRequestMethod** | **string** | HTTP method to use for the AWS request when auth_type is iam. This must match what has been signed in the presigned request. Currently, POST is the only supported value | [optional] 
**IamRequestBody** | **string** | Base64-encoded request body when auth_type is iam. This must match the request body included in the signature. | [optional] 
**IamRequestHeaders** | **string** | Key/value pairs of headers for use in the sts:GetCallerIdentity HTTP requests headers when auth_type is iam. Can be either a Base64-encoded, JSON-serialized string, or a JSON object of key/value pairs. This must at a minimum include the headers over which AWS has included a signature. | [optional] 
**IamRequestUrl** | **string** | Base64-encoded full URL against which to make the AWS request when using iam auth_type. | [optional] 
**Identity** | **string** | Base64 encoded EC2 instance identity document. This needs to be supplied along with the &#39;signature&#39; parameter. If using &#39;curl&#39; for fetching the identity document, consider using the option &#39;-w 0&#39; while piping the output to &#39;base64&#39; binary. | [optional] 
**Nonce** | **string** | The nonce to be used for subsequent login requests when auth_type is ec2. If this parameter is not specified at all and if reauthentication is allowed, then the backend will generate a random nonce, attaches it to the instance&#39;s identity access list entry and returns the nonce back as part of auth metadata. This value should be used with further login requests, to establish client authenticity. Clients can choose to set a custom nonce if preferred, in which case, it is recommended that clients provide a strong nonce. If a nonce is provided but with an empty value, it indicates intent to disable reauthentication. Note that, when &#39;disallow_reauthentication&#39; option is enabled on either the role or the role tag, the &#39;nonce&#39; holds no significance. | [optional] 
**Pkcs7** | **string** | PKCS7 signature of the identity document when using an auth_type of ec2. | [optional] 
**Role** | **string** | Name of the role against which the login is being attempted. If &#39;role&#39; is not specified, then the login endpoint looks for a role bearing the name of the AMI ID of the EC2 instance that is trying to login. If a matching role is not found, login fails. | [optional] 
**Signature** | **string** | Base64 encoded SHA256 RSA signature of the instance identity document. This needs to be supplied along with &#39;identity&#39; parameter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

