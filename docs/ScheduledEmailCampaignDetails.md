# TextMagicClient.Model.ScheduledEmailCampaignDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique scheduled campaign ID. | 
**Status** | **string** | Current scheduled campaign status. | 
**EmailSenderId** | **int?** | Email sender ID used for this campaign. | [optional] 
**StartAt** | **DateTime** | Scheduled start timestamp (UTC). | 
**EndAt** | **DateTime?** | End timestamp for recurring campaigns (UTC). | [optional] 
**NextSendAt** | **DateTime?** | Next scheduled send timestamp (UTC). | [optional] 
**CreatedBy** | [**UserPersonalInfo**](UserPersonalInfo.md) |  | 
**CreatedAt** | **DateTime** | Campaign creation timestamp. | 
**UpdatedAt** | **DateTime** | Last update timestamp. | 
**Type** | **string** | Campaign recurrence type. | 
**FromName** | **string** | Sender name displayed in recipient&#39;s inbox. | [optional] 
**FromEmail** | **string** | Sender email address. | 
**ReplyToEmail** | **string** | Reply-to email address. | 
**Subject** | **string** | Email subject line. | 
**Html** | **string** | HTML email content. | 
**RecipientsCount** | **int** | Number of recipients for this campaign. | 
**SendingTimezone** | **string** | Timezone for sending the campaign. | 
**Rrule** | **string** | RFC 5545 recurrence rule for recurring campaigns. | [optional] 
**OccurrenceSummary** | **string** | Human-readable schedule description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

