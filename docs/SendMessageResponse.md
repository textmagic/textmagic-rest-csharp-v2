# TextMagicClient.Model.SendMessageResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Message ID. | 
**Href** | **string** | URI of message session. | 
**Type** | **string** | Message response type: * **message** when message sent to a single recipient * **session** when message sent to multiple recipients * **schedule** when message has been scheduled for sending * **bulk** when message sent to multiple recipient and the number of recipients requires asynchronous processiong See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session).  | 
**SessionId** | **int?** | Message session ID. | 
**BulkId** | **int?** | Bulk Session ID. See [Sending more than 1,000 messages in one session](http://docs.textmagictesting.com/#section/Tutorials/Sending-more-than-1000-messages-in-one-session). | 
**MessageId** | **int?** | Message ID. | 
**ScheduleId** | **int?** | Message Schedule ID. | 
**ChatId** | **int?** | Message Chat ID. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

