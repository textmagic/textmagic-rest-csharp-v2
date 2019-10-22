# TextMagicClient.Model.UpdateContactInputObject
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | Contact first name | [optional] 
**LastName** | **string** | Contact last name | [optional] 
**Phone** | **string** | Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164). | 
**Email** | **string** | Contact email address. | [optional] 
**CompanyName** | **string** | Contact company name | [optional] 
**Lists** | **string** | Comma-separated [list](http://docs.textmagictesting.com/#section/Lists) ID. Each contact must be assigned to at least one list. | 
**Favorited** | **bool?** | Is contact marked as favorite. | [optional] 
**Blocked** | **bool?** | Is contact blocked for outgoing and incoming messaging. | [optional] 
**Type** | **int?** | Force type of phone. Possible values: 0 - landline, 1 - mobile. Default is -1 (auto detection). | [optional] 
**CustomFieldValues** | [**List&lt;CustomFieldListItem&gt;**](CustomFieldListItem.md) |  | [optional] 
**Local** | **int?** | Treat phone number passed in request body as **local**. | [optional] 
**Country** | **string** | 2-letter ISO country code for local phone numbers, used when **local** is set to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

