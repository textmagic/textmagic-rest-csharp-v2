# TextMagicClient.Model.MessageOut
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Message ID. | 
**Sender** | **string** | Message sender (phone number or alphanumeric Sender ID). | [optional] 
**Receiver** | **string** | Recipient phone number. | [optional] 
**Text** | **string** |  | 
**Status** | **string** | Delivery status of the message. See [message delivery statuses](http://docs.textmagictesting.com/#section/Delivery-status-codes) for details.  | 
**ContactId** | **int?** | Recipient contact ID. | 
**SessionId** | **int?** | Message Session ID of a Message. | 
**MessageTime** | **DateTime?** | Sending time. | 
**Avatar** | **string** |  | 
**Deleted** | **bool?** | Indicates that message has been deleted. | [optional] 
**Charset** | **string** | Message charset. Could be: *   **ISO-8859-1** for plaintext SMS *   **UTF-16BE** for Unicode SMS  | 
**CharsetLabel** | **string** | Human-readable message charset label. Could be: *   **ISO-8859-1** for plaintext SMS *   **UTF-16BE** for Unicode SMS *   **Voice** for voice services (Text-to-Speech or Voice Broadcast) messages  | 
**FirstName** | **string** | Contact first name. Could be substituted from your [Contacts](http://docs.textmagictesting.com/#tag/Contacts) (even if you submitted phone number instead of contact ID).  | 
**LastName** | **string** | Contact last name. | 
**Country** | **string** | Two-letter ISO country code of the recipient phone number.  | 
**Phone** | **string** | Receipent phone number. | [optional] 
**Price** | **float?** | Message price. | [optional] 
**PartsCount** | **int?** | Message parts (multiples of 160 characters) count. | 
**FromEmail** | **string** | User email which this message came from. For Email2SMS and Distribution Lists messages it will be an original email address, in other cases it is an account email address. | [optional] 
**FromNumber** | **string** | Phone number which is used to send SMS. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

