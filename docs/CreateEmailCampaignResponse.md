# TextMagicClient.Model.CreateEmailCampaignResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique campaign ID. | 
**Status** | **string** | Current campaign status. | 
**EmailSenderId** | **int?** | Email sender ID used for this campaign. | [optional] 
**StartAt** | **DateTime** | Campaign start timestamp. | 
**CreatedBy** | [**UserPersonalInfo**](UserPersonalInfo.md) |  | 
**FromName** | **string** | Sender name displayed in recipient&#39;s inbox. | [optional] 
**FromEmail** | **string** | Sender email address. | 
**ReplyToEmail** | **string** | Reply-to email address. | 
**Subject** | **string** | Email subject line. | 
**Html** | **string** | HTML email content. | 
**Cost** | **float** | Total campaign cost. | 
**Totals** | [**EmailCampaignStatisticTotals**](EmailCampaignStatisticTotals.md) |  | 
**OutboundEmail** | [**OutboundEmailResponse**](OutboundEmailResponse.md) |  | [optional] 
**FailedReason** | **string** | Reason for campaign failure if applicable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

