# TextMagicClient.Model.Chat
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Chat ID. | 
**OriginalId** | **int?** |  | 
**Phone** | **string** | Chat partner phone number. | 
**Contact** | [**Contact**](Contact.md) |  | 
**UnsubscribedContactId** | **int?** | If this field has a value then it means that chat phone number has been unsubscribed from you and this value is a ID of a Unsubscribed contact entity. See [Get all unsubscribed contacts](http://docs.textmagictesting.com/#operation/getUnsubscribers). | 
**Unread** | **int?** | Total unread incoming messages. | 
**UpdatedAt** | **DateTime?** | Time when last incoming message arrived at this chat. | 
**Status** | **string** | Chat status:   * **a** - Active   * **c** - Closed   * **d** - Deleted  | 
**Mute** | **int?** | Indicates when chat is muted. | 
**LastMessage** | **string** | The last message content of a chat. | 
**Direction** | **string** | Last message type: * **ci** - incoming call * **co** - outgoing call * **i** - incoming message * **o** - outgoing message  | 
**From** | **string** | If filled then value will be used as a sender number for all outgoing messages of a chat. | 
**MutedUntil** | **DateTime?** | Date and time until chat will be mutted. | 
**TimeLeftMute** | **int?** | Time left till chat will be unmutted (seconds). | 
**Country** | [**Country**](Country.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

