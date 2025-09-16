# TextMagicClient.Model.OutboundEmailResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Outbound email ID. | 
**SendTime** | **DateTime?** | Email send timestamp. | 
**FromName** | **string** | Sender name. | [optional] 
**FromEmail** | **string** | Sender email address. | 
**ReplyToEmail** | **string** | Reply-to email address. | 
**RecipientFullName** | **string** | Recipient&#39;s full name. | [optional] 
**RecipientEmail** | **string** | Recipient&#39;s email address. | [optional] 
**EmailSubject** | **string** | Email subject line. | 
**EmailContent** | **string** | HTML email content. | 
**Source** | **string** | Source of the outbound email. | 
**Status** | **string** | Current email status. | 
**Cost** | **float?** | Cost of sending this email. | 
**StatusReason** | **string** | Detailed status reason. | [optional] 
**ContactId** | **int?** | Associated contact ID. | [optional] 
**InitiatorId** | **int?** | ID of user who initiated the email. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

