# TextMagicClient.Api.TextMagicApi

All URIs are relative to *https://rest.textmagic.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AssignContactsToList**](TextMagicApi.md#assigncontactstolist) | **PUT** /api/v2/lists/{id}/contacts | Assign contacts to a list |
| [**BlockContact**](TextMagicApi.md#blockcontact) | **POST** /api/v2/contacts/block | Block a contact by phone number |
| [**BuyDedicatedNumber**](TextMagicApi.md#buydedicatednumber) | **POST** /api/v2/numbers | Buy a dedicated number |
| [**ClearAndAssignContactsToList**](TextMagicApi.md#clearandassigncontactstolist) | **POST** /api/v2/lists/{id}/contacts | Reset list members to the specified contacts |
| [**CloseChatsBulk**](TextMagicApi.md#closechatsbulk) | **POST** /api/v2/chats/close/bulk | Close chats (bulk) |
| [**CloseReadChats**](TextMagicApi.md#closereadchats) | **POST** /api/v2/chats/close/read | Close read chats |
| [**CreateContact**](TextMagicApi.md#createcontact) | **POST** /api/v2/contacts/normalized | Add a new contact |
| [**CreateContactNote**](TextMagicApi.md#createcontactnote) | **POST** /api/v2/contacts/{id}/notes | Create a new contact note |
| [**CreateCustomField**](TextMagicApi.md#createcustomfield) | **POST** /api/v2/customfields | Add a new custom field |
| [**CreateEmailCampaign**](TextMagicApi.md#createemailcampaign) | **POST** /api/v2/email-campaigns | Send email campaign |
| [**CreateList**](TextMagicApi.md#createlist) | **POST** /api/v2/lists | Create a new list |
| [**CreateTag**](TextMagicApi.md#createtag) | **POST** /api/v2/tags | Create tag |
| [**CreateTemplate**](TextMagicApi.md#createtemplate) | **POST** /api/v2/templates | Create a template |
| [**DeleteAllContacts**](TextMagicApi.md#deleteallcontacts) | **DELETE** /api/v2/contact/all | Delete contacts (bulk) |
| [**DeleteAllOutboundMessages**](TextMagicApi.md#deletealloutboundmessages) | **DELETE** /api/v2/message/all | Delete all messages |
| [**DeleteAvatar**](TextMagicApi.md#deleteavatar) | **DELETE** /api/v2/user/avatar | Delete an avatar |
| [**DeleteChatMessages**](TextMagicApi.md#deletechatmessages) | **POST** /api/v2/chats/{id}/messages/delete | Delete chat messages by ID(s) |
| [**DeleteChatsBulk**](TextMagicApi.md#deletechatsbulk) | **POST** /api/v2/chats/delete | Delete chats (bulk) |
| [**DeleteContact**](TextMagicApi.md#deletecontact) | **DELETE** /api/v2/contacts/{id} | Delete a contact |
| [**DeleteContactAvatar**](TextMagicApi.md#deletecontactavatar) | **DELETE** /api/v2/contacts/{id}/avatar | Delete an avatar |
| [**DeleteContactNote**](TextMagicApi.md#deletecontactnote) | **DELETE** /api/v2/notes/{id} | Delete a contact note |
| [**DeleteContactNotesBulk**](TextMagicApi.md#deletecontactnotesbulk) | **POST** /api/v2/contacts/{id}/notes/delete | Delete contact notes (bulk) |
| [**DeleteContactsByIds**](TextMagicApi.md#deletecontactsbyids) | **POST** /api/v2/contacts/delete | Delete contacts by IDs (bulk) |
| [**DeleteContactsFromList**](TextMagicApi.md#deletecontactsfromlist) | **DELETE** /api/v2/lists/{id}/contacts | Unassign contacts from a list |
| [**DeleteCustomField**](TextMagicApi.md#deletecustomfield) | **DELETE** /api/v2/customfields/{id} | Delete a custom field |
| [**DeleteDedicatedNumber**](TextMagicApi.md#deletededicatednumber) | **DELETE** /api/v2/numbers/{id} | Cancel a dedicated number subscription |
| [**DeleteInboundMessage**](TextMagicApi.md#deleteinboundmessage) | **DELETE** /api/v2/replies/{id} | Delete a single inbound message |
| [**DeleteInboundMessagesBulk**](TextMagicApi.md#deleteinboundmessagesbulk) | **POST** /api/v2/replies/delete | Delete inbound messages (bulk) |
| [**DeleteList**](TextMagicApi.md#deletelist) | **DELETE** /api/v2/lists/{id} | Delete a list |
| [**DeleteListAvatar**](TextMagicApi.md#deletelistavatar) | **DELETE** /api/v2/lists/{id}/avatar | Delete an avatar for a list |
| [**DeleteListContactsBulk**](TextMagicApi.md#deletelistcontactsbulk) | **POST** /api/v2/lists/{id}/contacts/delete | Delete contacts from a list (bulk) |
| [**DeleteListsBulk**](TextMagicApi.md#deletelistsbulk) | **POST** /api/v2/lists/delete | Delete lists (bulk) |
| [**DeleteMessageSession**](TextMagicApi.md#deletemessagesession) | **DELETE** /api/v2/sessions/{id} | Delete a session |
| [**DeleteMessageSessionsBulk**](TextMagicApi.md#deletemessagesessionsbulk) | **POST** /api/v2/sessions/delete | Delete sessions (bulk) |
| [**DeleteOutboundMessage**](TextMagicApi.md#deleteoutboundmessage) | **DELETE** /api/v2/messages/{id} | Delete message |
| [**DeleteOutboundMessagesBulk**](TextMagicApi.md#deleteoutboundmessagesbulk) | **POST** /api/v2/messages/delete | Delete messages (bulk) |
| [**DeleteScheduledMessage**](TextMagicApi.md#deletescheduledmessage) | **DELETE** /api/v2/schedules/{id} | Delete a single scheduled message |
| [**DeleteScheduledMessagesBulk**](TextMagicApi.md#deletescheduledmessagesbulk) | **POST** /api/v2/schedules/delete | Delete scheduled messages (bulk) |
| [**DeleteSenderId**](TextMagicApi.md#deletesenderid) | **DELETE** /api/v2/senderids/{id} | Delete a Sender ID |
| [**DeleteTemplate**](TextMagicApi.md#deletetemplate) | **DELETE** /api/v2/templates/{id} | Delete a template |
| [**DeleteTemplatesBulk**](TextMagicApi.md#deletetemplatesbulk) | **POST** /api/v2/templates/delete | Delete templates (bulk) |
| [**DoCarrierLookup**](TextMagicApi.md#docarrierlookup) | **GET** /api/v2/lookups/{phone} | Carrier Lookup |
| [**DoEmailLookup**](TextMagicApi.md#doemaillookup) | **GET** /api/v2/email-lookups/{email} | Email Lookup |
| [**GetAllBulkSessions**](TextMagicApi.md#getallbulksessions) | **GET** /api/v2/bulks | Get all bulk sessions |
| [**GetAllChats**](TextMagicApi.md#getallchats) | **GET** /api/v2/chats | Get all chats |
| [**GetAllInboundMessages**](TextMagicApi.md#getallinboundmessages) | **GET** /api/v2/replies | Get all inbound messages |
| [**GetAllMessageSessions**](TextMagicApi.md#getallmessagesessions) | **GET** /api/v2/sessions | Get all sessions |
| [**GetAllOutboundMessages**](TextMagicApi.md#getalloutboundmessages) | **GET** /api/v2/messages | Get all messages |
| [**GetAllScheduledMessages**](TextMagicApi.md#getallscheduledmessages) | **GET** /api/v2/schedules | Get all scheduled messages |
| [**GetAllTemplates**](TextMagicApi.md#getalltemplates) | **GET** /api/v2/templates | Get all templates |
| [**GetAvailableDedicatedNumbers**](TextMagicApi.md#getavailablededicatednumbers) | **GET** /api/v2/numbers/available | Find dedicated numbers available for purchase |
| [**GetAvailableSenderSettingOptions**](TextMagicApi.md#getavailablesendersettingoptions) | **GET** /api/v2/sources | Get available sender settings |
| [**GetBalanceNotificationOptions**](TextMagicApi.md#getbalancenotificationoptions) | **GET** /api/v2/user/notification/balance/bundles | Returns the list of available balance options which can be used as a bound to determine when to send email to user with low balance notification. See https://my.textmagic.com/online/account/notifications/balance |
| [**GetBalanceNotificationSettings**](TextMagicApi.md#getbalancenotificationsettings) | **GET** /api/v2/user/notification/balance | Get balance notification settings |
| [**GetBlockedContacts**](TextMagicApi.md#getblockedcontacts) | **GET** /api/v2/contacts/block/list | Get blocked contacts |
| [**GetBulkSession**](TextMagicApi.md#getbulksession) | **GET** /api/v2/bulks/{id} | Get bulk session status |
| [**GetCallbackSettings**](TextMagicApi.md#getcallbacksettings) | **GET** /api/v2/callback/settings | Fetch callback URL settings |
| [**GetChat**](TextMagicApi.md#getchat) | **GET** /api/v2/chats/{id} | Get a single chat |
| [**GetChatByPhone**](TextMagicApi.md#getchatbyphone) | **GET** /api/v2/chats/{phone}/by/phone | Find chats by phone |
| [**GetChatMessages**](TextMagicApi.md#getchatmessages) | **GET** /api/v2/chats/{id}/message | Get chat messages |
| [**GetContact**](TextMagicApi.md#getcontact) | **GET** /api/v2/contacts/{id} | Get the details of a specific contact |
| [**GetContactByPhone**](TextMagicApi.md#getcontactbyphone) | **GET** /api/v2/contacts/phone/{phone} | Get the details of a specific contact by phone number |
| [**GetContactIfBlocked**](TextMagicApi.md#getcontactifblocked) | **GET** /api/v2/contacts/block/phone | Check if a phone number is blocked |
| [**GetContactImportSessionProgress**](TextMagicApi.md#getcontactimportsessionprogress) | **GET** /api/v2/contacts/import/progress/{id} | Check import progress |
| [**GetContactNote**](TextMagicApi.md#getcontactnote) | **GET** /api/v2/notes/{id} | Get a contact note |
| [**GetContactNotes**](TextMagicApi.md#getcontactnotes) | **GET** /api/v2/contacts/{id}/notes | Fetch notes assigned to a given contact |
| [**GetContacts**](TextMagicApi.md#getcontacts) | **GET** /api/v2/contacts | Get all contacts |
| [**GetContactsAutocomplete**](TextMagicApi.md#getcontactsautocomplete) | **GET** /api/v2/contacts/autocomplete | Get contacts autocomplete suggestions |
| [**GetContactsByListId**](TextMagicApi.md#getcontactsbylistid) | **GET** /api/v2/lists/{id}/contacts | Get all contacts in a list |
| [**GetCountries**](TextMagicApi.md#getcountries) | **GET** /api/v2/countries | Get countries |
| [**GetCurrentUser**](TextMagicApi.md#getcurrentuser) | **GET** /api/v2/user | Get current account information |
| [**GetCustomField**](TextMagicApi.md#getcustomfield) | **GET** /api/v2/customfields/{id} | Get the details of a specific custom field |
| [**GetCustomFields**](TextMagicApi.md#getcustomfields) | **GET** /api/v2/customfields | Get all custom fields |
| [**GetDedicatedNumber**](TextMagicApi.md#getdedicatednumber) | **GET** /api/v2/numbers/{id} | Get the details of a specific dedicated number |
| [**GetEmailSenders**](TextMagicApi.md#getemailsenders) | **GET** /api/v2/email-campaigns/email-senders | Get list of email senders |
| [**GetFavorites**](TextMagicApi.md#getfavorites) | **GET** /api/v2/contacts/favorite | Get favorite contacts and lists |
| [**GetInboundMessage**](TextMagicApi.md#getinboundmessage) | **GET** /api/v2/replies/{id} | Get a single inbound message |
| [**GetInboundMessagesNotificationSettings**](TextMagicApi.md#getinboundmessagesnotificationsettings) | **GET** /api/v2/user/notification/inbound | Get inbound messages notification settings |
| [**GetInvoices**](TextMagicApi.md#getinvoices) | **GET** /api/v2/invoices | Get all invoices |
| [**GetList**](TextMagicApi.md#getlist) | **GET** /api/v2/lists/{id} | Get the details of a specific list |
| [**GetListContactsIds**](TextMagicApi.md#getlistcontactsids) | **GET** /api/v2/lists/{id}/contacts/ids | Get all contact IDs in a list |
| [**GetLists**](TextMagicApi.md#getlists) | **GET** /api/v2/lists | Get all lists |
| [**GetListsOfContact**](TextMagicApi.md#getlistsofcontact) | **GET** /api/v2/contacts/{id}/lists | Get a contact&#39;s lists |
| [**GetMessagePreview**](TextMagicApi.md#getmessagepreview) | **GET** /api/v2/messages/preview | Preview message |
| [**GetMessagePrice**](TextMagicApi.md#getmessageprice) | **GET** /api/v2/messages/price/normalized | Check message price |
| [**GetMessageSession**](TextMagicApi.md#getmessagesession) | **GET** /api/v2/sessions/{id} | Get a session&#x60;s details |
| [**GetMessageSessionStat**](TextMagicApi.md#getmessagesessionstat) | **GET** /api/v2/sessions/{id}/stat | Get a session&#x60;s statistics |
| [**GetMessagesBySessionId**](TextMagicApi.md#getmessagesbysessionid) | **GET** /api/v2/sessions/{id}/messages | Get a session&#x60;s messages |
| [**GetMessagingCounters**](TextMagicApi.md#getmessagingcounters) | **GET** /api/v2/stats/messaging/data | Get sent/received messages counters values |
| [**GetMessagingStat**](TextMagicApi.md#getmessagingstat) | **GET** /api/v2/stats/messaging | Get messaging statistics |
| [**GetOutboundMessage**](TextMagicApi.md#getoutboundmessage) | **GET** /api/v2/messages/{id} | Get a single message |
| [**GetOutboundMessagesHistory**](TextMagicApi.md#getoutboundmessageshistory) | **GET** /api/v2/history | Get history |
| [**GetScheduledMessage**](TextMagicApi.md#getscheduledmessage) | **GET** /api/v2/schedules/{id} | Get a single scheduled message |
| [**GetSenderId**](TextMagicApi.md#getsenderid) | **GET** /api/v2/senderids/{id} | Get the details of a specific Sender ID |
| [**GetSenderIds**](TextMagicApi.md#getsenderids) | **GET** /api/v2/senderids | Get all your approved Sender IDs |
| [**GetSenderSettings**](TextMagicApi.md#getsendersettings) | **GET** /api/v2/sender/settings/normalized | Get current sender settings |
| [**GetSpendingStat**](TextMagicApi.md#getspendingstat) | **GET** /api/v2/stats/spending | Get spending statistics |
| [**GetTemplate**](TextMagicApi.md#gettemplate) | **GET** /api/v2/templates/{id} | Get a template&#x60;s details |
| [**GetTimezones**](TextMagicApi.md#gettimezones) | **GET** /api/v2/timezones | Get timezones |
| [**GetUnreadMessagesTotal**](TextMagicApi.md#getunreadmessagestotal) | **GET** /api/v2/chats/unread/count | Get unread messages number |
| [**GetUnsubscribedContact**](TextMagicApi.md#getunsubscribedcontact) | **GET** /api/v2/unsubscribers/{id} | Get the details of a specific unsubscribed contact |
| [**GetUnsubscribers**](TextMagicApi.md#getunsubscribers) | **GET** /api/v2/unsubscribers | Get all unsubscribed contacts |
| [**GetUserDedicatedNumbers**](TextMagicApi.md#getuserdedicatednumbers) | **GET** /api/v2/numbers | Get all your dedicated numbers |
| [**ImportContacts**](TextMagicApi.md#importcontacts) | **POST** /api/v2/contacts/import/normalized | Import contacts |
| [**MarkChatsReadBulk**](TextMagicApi.md#markchatsreadbulk) | **POST** /api/v2/chats/read/bulk | Mark chats as read (bulk) |
| [**MarkChatsUnreadBulk**](TextMagicApi.md#markchatsunreadbulk) | **POST** /api/v2/chats/unread/bulk | Mark chats as unread (bulk) |
| [**MuteChat**](TextMagicApi.md#mutechat) | **POST** /api/v2/chats/mute | Mute chat sounds |
| [**MuteChatsBulk**](TextMagicApi.md#mutechatsbulk) | **POST** /api/v2/chats/mute/bulk | Mute chats (bulk) |
| [**Ping**](TextMagicApi.md#ping) | **GET** /api/v2/ping | Ping |
| [**ReopenChatsBulk**](TextMagicApi.md#reopenchatsbulk) | **POST** /api/v2/chats/reopen/bulk | Reopen chats (bulk) |
| [**RequestSenderId**](TextMagicApi.md#requestsenderid) | **POST** /api/v2/senderids | Apply for a new Sender ID |
| [**ScheduleEmailCampaign**](TextMagicApi.md#scheduleemailcampaign) | **POST** /api/v2/email-campaigns/schedule | Schedule new email campaign |
| [**SearchChats**](TextMagicApi.md#searchchats) | **GET** /api/v2/chats/search | Find chats by message text |
| [**SearchChatsByIds**](TextMagicApi.md#searchchatsbyids) | **GET** /api/v2/chats/search/ids | Find chats (bulk) |
| [**SearchChatsByReceipent**](TextMagicApi.md#searchchatsbyreceipent) | **GET** /api/v2/chats/search/recipients | Find chats by recipient |
| [**SearchContacts**](TextMagicApi.md#searchcontacts) | **GET** /api/v2/contacts/search | Find contacts by given criteria |
| [**SearchInboundMessages**](TextMagicApi.md#searchinboundmessages) | **GET** /api/v2/replies/search | Find inbound messages |
| [**SearchLists**](TextMagicApi.md#searchlists) | **GET** /api/v2/lists/search | Find lists by given criteria |
| [**SearchOutboundMessages**](TextMagicApi.md#searchoutboundmessages) | **GET** /api/v2/messages/search | Find messages |
| [**SearchScheduledMessages**](TextMagicApi.md#searchscheduledmessages) | **GET** /api/v2/schedules/search | Find scheduled messages |
| [**SearchTemplates**](TextMagicApi.md#searchtemplates) | **GET** /api/v2/templates/search | Find templates by criteria |
| [**SendMessage**](TextMagicApi.md#sendmessage) | **POST** /api/v2/messages | Send message |
| [**SetChatStatus**](TextMagicApi.md#setchatstatus) | **POST** /api/v2/chats/status | Change chat status |
| [**UnblockContact**](TextMagicApi.md#unblockcontact) | **POST** /api/v2/contacts/unblock | Unblock a contact by phone number |
| [**UnblockContactsBulk**](TextMagicApi.md#unblockcontactsbulk) | **POST** /api/v2/contacts/unblock/bulk | Unblock contacts (bulk) |
| [**UnmuteChatsBulk**](TextMagicApi.md#unmutechatsbulk) | **POST** /api/v2/chats/unmute/bulk | Unmute chats (bulk) |
| [**UnsubscribeContact**](TextMagicApi.md#unsubscribecontact) | **POST** /api/v2/unsubscribers | Manually unsubscribe a contact |
| [**UpdateBalanceNotificationSettings**](TextMagicApi.md#updatebalancenotificationsettings) | **PUT** /api/v2/user/notification/balance | Update balance notification settings |
| [**UpdateCallbackSettings**](TextMagicApi.md#updatecallbacksettings) | **PUT** /api/v2/callback/settings | Update callback URL settings |
| [**UpdateChatDesktopNotificationSettings**](TextMagicApi.md#updatechatdesktopnotificationsettings) | **PUT** /api/v2/user/desktop/notification | Update chat desktop notification settings |
| [**UpdateContact**](TextMagicApi.md#updatecontact) | **PUT** /api/v2/contacts/{id}/normalized | Edit a contact |
| [**UpdateContactNote**](TextMagicApi.md#updatecontactnote) | **PUT** /api/v2/notes/{id} | Update a contact note |
| [**UpdateCurrentUser**](TextMagicApi.md#updatecurrentuser) | **PUT** /api/v2/user | Edit current account info |
| [**UpdateCustomField**](TextMagicApi.md#updatecustomfield) | **PUT** /api/v2/customfields/{id} | Edit a custom field |
| [**UpdateCustomFieldValue**](TextMagicApi.md#updatecustomfieldvalue) | **PUT** /api/v2/customfields/{id}/update | Edit the custom field value of a specified contact |
| [**UpdateInboundMessagesNotificationSettings**](TextMagicApi.md#updateinboundmessagesnotificationsettings) | **PUT** /api/v2/user/notification/inbound | Update inbound messages notification settings |
| [**UpdateList**](TextMagicApi.md#updatelist) | **PUT** /api/v2/lists/{id} | Edit a list |
| [**UpdateSenderSetting**](TextMagicApi.md#updatesendersetting) | **PUT** /api/v2/sender/settings | Change sender settings |
| [**UpdateTemplate**](TextMagicApi.md#updatetemplate) | **PUT** /api/v2/templates/{id} | Update a template |
| [**UploadAvatar**](TextMagicApi.md#uploadavatar) | **POST** /api/v2/user/avatar | Upload an avatar |
| [**UploadContactAvatar**](TextMagicApi.md#uploadcontactavatar) | **POST** /api/v2/contacts/{id}/avatar | Upload an avatar |
| [**UploadListAvatar**](TextMagicApi.md#uploadlistavatar) | **POST** /api/v2/lists/{id}/avatar | Add an avatar for a list |
| [**UploadMessageAttachment**](TextMagicApi.md#uploadmessageattachment) | **POST** /api/v2/messages/attachment | Upload message attachment |
| [**UploadMessageMMSAttachment**](TextMagicApi.md#uploadmessagemmsattachment) | **POST** /api/v2/messages/mms/attachment | Upload message mms attachment |

<a id="assigncontactstolist"></a>
# **AssignContactsToList**
> ResourceLinkResponse AssignContactsToList (int id, AssignContactsToListRequest assignContactsToListInputObject)

Assign contacts to a list

> Unlike all other PUT requests, this command does not need old contact IDs to be submitted. For example, if you have a list with contacts 150, 151 and 152 and you want to add contact ID 153, you only need to submit 153 as a parameter of PUT /api/v2/lists/{id}/contacts. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class AssignContactsToListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var assignContactsToListInputObject = new AssignContactsToListRequest(); // AssignContactsToListRequest | 

            try
            {
                // Assign contacts to a list
                ResourceLinkResponse result = apiInstance.AssignContactsToList(id, assignContactsToListInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.AssignContactsToList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AssignContactsToListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign contacts to a list
    ApiResponse<ResourceLinkResponse> response = apiInstance.AssignContactsToListWithHttpInfo(id, assignContactsToListInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.AssignContactsToListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **assignContactsToListInputObject** | [**AssignContactsToListRequest**](AssignContactsToListRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a list shared to the current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="blockcontact"></a>
# **BlockContact**
> ResourceLinkResponse BlockContact (BlockContactRequest blockContactInputObject)

Block a contact by phone number

Block a contact from inbound and outbound communication by phone number.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class BlockContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var blockContactInputObject = new BlockContactRequest(); // BlockContactRequest | 

            try
            {
                // Block a contact by phone number
                ResourceLinkResponse result = apiInstance.BlockContact(blockContactInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.BlockContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BlockContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Block a contact by phone number
    ApiResponse<ResourceLinkResponse> response = apiInstance.BlockContactWithHttpInfo(blockContactInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.BlockContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockContactInputObject** | [**BlockContactRequest**](BlockContactRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when updated with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="buydedicatednumber"></a>
# **BuyDedicatedNumber**
> void BuyDedicatedNumber (BuyDedicatedNumberRequest buyDedicatedNumberInputObject)

Buy a dedicated number

To buy a dedicated number, you first need to find an available number matching your criteria using the `/api/v2/numbers/available` command described above.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class BuyDedicatedNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var buyDedicatedNumberInputObject = new BuyDedicatedNumberRequest(); // BuyDedicatedNumberRequest | 

            try
            {
                // Buy a dedicated number
                apiInstance.BuyDedicatedNumber(buyDedicatedNumberInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.BuyDedicatedNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuyDedicatedNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Buy a dedicated number
    apiInstance.BuyDedicatedNumberWithHttpInfo(buyDedicatedNumberInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.BuyDedicatedNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **buyDedicatedNumberInputObject** | [**BuyDedicatedNumberRequest**](BuyDedicatedNumberRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Number has been bought with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="clearandassigncontactstolist"></a>
# **ClearAndAssignContactsToList**
> ResourceLinkResponse ClearAndAssignContactsToList (int id, ClearAndAssignContactsToListRequest clearAndAssignContactsToListInputObject)

Reset list members to the specified contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class ClearAndAssignContactsToListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var clearAndAssignContactsToListInputObject = new ClearAndAssignContactsToListRequest(); // ClearAndAssignContactsToListRequest | 

            try
            {
                // Reset list members to the specified contacts
                ResourceLinkResponse result = apiInstance.ClearAndAssignContactsToList(id, clearAndAssignContactsToListInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.ClearAndAssignContactsToList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClearAndAssignContactsToListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset list members to the specified contacts
    ApiResponse<ResourceLinkResponse> response = apiInstance.ClearAndAssignContactsToListWithHttpInfo(id, clearAndAssignContactsToListInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.ClearAndAssignContactsToListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **clearAndAssignContactsToListInputObject** | [**ClearAndAssignContactsToListRequest**](ClearAndAssignContactsToListRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a list shared to the current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="closechatsbulk"></a>
# **CloseChatsBulk**
> void CloseChatsBulk (MarkChatsUnreadBulkRequest closeChatsBulkInputObject)

Close chats (bulk)

Close chats by chat IDs or close all chats

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CloseChatsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var closeChatsBulkInputObject = new MarkChatsUnreadBulkRequest(); // MarkChatsUnreadBulkRequest | 

            try
            {
                // Close chats (bulk)
                apiInstance.CloseChatsBulk(closeChatsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CloseChatsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloseChatsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Close chats (bulk)
    apiInstance.CloseChatsBulkWithHttpInfo(closeChatsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CloseChatsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **closeChatsBulkInputObject** | [**MarkChatsUnreadBulkRequest**](MarkChatsUnreadBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="closereadchats"></a>
# **CloseReadChats**
> void CloseReadChats ()

Close read chats

Close all chats that have no unread messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CloseReadChatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Close read chats
                apiInstance.CloseReadChats();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CloseReadChats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloseReadChatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Close read chats
    apiInstance.CloseReadChatsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CloseReadChatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontact"></a>
# **CreateContact**
> ResourceLinkResponse CreateContact (CreateContactRequest createContactInputObject)

Add a new contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var createContactInputObject = new CreateContactRequest(); // CreateContactRequest | 

            try
            {
                // Add a new contact
                ResourceLinkResponse result = apiInstance.CreateContact(createContactInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new contact
    ApiResponse<ResourceLinkResponse> response = apiInstance.CreateContactWithHttpInfo(createContactInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createContactInputObject** | [**CreateContactRequest**](CreateContactRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Contact has been created with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontactnote"></a>
# **CreateContactNote**
> ResourceLinkResponse CreateContactNote (int id, CreateContactNoteRequest createContactNoteInputObject)

Create a new contact note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateContactNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var createContactNoteInputObject = new CreateContactNoteRequest(); // CreateContactNoteRequest | 

            try
            {
                // Create a new contact note
                ResourceLinkResponse result = apiInstance.CreateContactNote(id, createContactNoteInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateContactNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new contact note
    ApiResponse<ResourceLinkResponse> response = apiInstance.CreateContactNoteWithHttpInfo(id, createContactNoteInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateContactNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **createContactNoteInputObject** | [**CreateContactNoteRequest**](CreateContactNoteRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when created with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcustomfield"></a>
# **CreateCustomField**
> ResourceLinkResponse CreateCustomField (CreateCustomFieldRequest createCustomFieldInputObject)

Add a new custom field

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var createCustomFieldInputObject = new CreateCustomFieldRequest(); // CreateCustomFieldRequest | 

            try
            {
                // Add a new custom field
                ResourceLinkResponse result = apiInstance.CreateCustomField(createCustomFieldInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new custom field
    ApiResponse<ResourceLinkResponse> response = apiInstance.CreateCustomFieldWithHttpInfo(createCustomFieldInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCustomFieldInputObject** | [**CreateCustomFieldRequest**](CreateCustomFieldRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Contact has been created with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createemailcampaign"></a>
# **CreateEmailCampaign**
> CreateEmailCampaignResponse CreateEmailCampaign (CreateEmailCampaignRequest createEmailCampaignInputObject)

Send email campaign

Creates a new email campaign and sends it to the specified recipients.  This endpoint allows you to create and immediately send an email marketing campaign to your contacts, groups, or direct email addresses. The campaign will be processed asynchronously, and you'll receive a campaign object with tracking information.  ## Request Requirements  - **Email Sender ID**: Must be a valid, configured email sender from your account - **Recipients**: At least one recipient type must be specified (contacts, groups, or emails) - **Content**: Subject and HTML message content are required - **Balance**: Sufficient account balance for the estimated campaign cost  ## Recipient Types  You can target multiple recipient types in a single campaign:  - **Contact IDs**: Send to specific contacts from your contact list - **Group IDs**: Send to all contacts within specified groups   - **Direct Emails**: Send to email addresses not in your contact list  ## Content Guidelines  - **Subject**: Maximum 998 characters, should be engaging and relevant - **Message**: HTML content supported, including images, links, and formatting - **From Name**: Optional custom sender name (max 500 characters) - **Reply-To**: Optional custom reply-to email address  ## Cost and Balance  The API automatically calculates campaign costs based on: - Total number of unique recipients across all specified groups, contacts, and emails - Your account's email pricing tier - Any additional features or premium content  If your account balance is insufficient, the request will be rejected with a low balance error.  ## Response Information  Successful campaigns return: - Campaign ID for tracking and analytics - Current campaign status and progress - Cost breakdown and recipient counts - Sender information and content preview - Statistical totals and engagement metrics  ## Error Scenarios  Common error conditions include: - **Validation Errors**: Invalid email addresses, missing required fields, or content that exceeds limits - **Insufficient Balance**: Account balance too low for campaign cost - **Invalid Recipients**: Non-existent contact/group IDs or invalid email formats - **Sender Configuration**: Invalid or unconfigured email sender ID - **No Recipients**: All recipient arrays are empty or invalid 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var createEmailCampaignInputObject = new CreateEmailCampaignRequest(); // CreateEmailCampaignRequest | 

            try
            {
                // Send email campaign
                CreateEmailCampaignResponse result = apiInstance.CreateEmailCampaign(createEmailCampaignInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send email campaign
    ApiResponse<CreateEmailCampaignResponse> response = apiInstance.CreateEmailCampaignWithHttpInfo(createEmailCampaignInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEmailCampaignInputObject** | [**CreateEmailCampaignRequest**](CreateEmailCampaignRequest.md) |  |  |

### Return type

[**CreateEmailCampaignResponse**](CreateEmailCampaignResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Email campaign created successfully. |  -  |
| **400** | Bad request - validation errors or insufficient balance. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Forbidden - insufficient permissions (requires ComposeEmail access). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createlist"></a>
# **CreateList**
> ResourceLinkResponse CreateList (CreateListRequest createListInputObject)

Create a new list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var createListInputObject = new CreateListRequest(); // CreateListRequest | 

            try
            {
                // Create a new list
                ResourceLinkResponse result = apiInstance.CreateList(createListInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new list
    ApiResponse<ResourceLinkResponse> response = apiInstance.CreateListWithHttpInfo(createListInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createListInputObject** | [**CreateListRequest**](CreateListRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtag"></a>
# **CreateTag**
> CreateTagResponse CreateTag (CreateTagRequest createTagInputObject)

Create tag

Creates a new tag for organizing and categorizing contacts.  This endpoint allows you to create a custom tag that can be used to segment and organize your contact database. Tags provide a flexible way to categorize contacts for better contact management.  ## Request Requirements  - **Title**: Required field, must be between 1 and 50 characters - **Uniqueness**: Tag titles must be unique within your account - **Authentication**: Valid API credentials required  ## Common Use Cases  Create tags for various organizational purposes:  - **Customer Types**: \"VIP Customer\", \"New Lead\", \"Active Subscriber\" - **Geographic Segments**: \"North Region\", \"Europe\", \"Local Customers\" - **Engagement Levels**: \"Highly Engaged\", \"Inactive\", \"Recent Purchase\" - **Campaign Categories**: \"Summer Promotion\", \"Newsletter Subscriber\", \"Event Attendee\" - **Custom Segments**: Any custom categorization that fits your business needs  ## Response Information  Successful tag creation returns: - **Tag ID**: Unique identifier for the newly created tag - **Title**: The tag name as provided in the request  Use the returned tag ID to assign this tag to contacts or reference it in other API operations.  ## Error Scenarios  Common error conditions include: - **Validation Errors**: Title exceeds 50 characters or is empty - **Duplicate Tag**: A tag with the same title already exists in your account - **Authentication Errors**: Invalid or missing API credentials  ## Next Steps  After creating a tag: 1. Use the tag ID to assign it to contacts via contact management endpoints 2. Reference the tag when filtering contacts 3. Manage and update tags through other Tags API endpoints 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var createTagInputObject = new CreateTagRequest(); // CreateTagRequest | 

            try
            {
                // Create tag
                CreateTagResponse result = apiInstance.CreateTag(createTagInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create tag
    ApiResponse<CreateTagResponse> response = apiInstance.CreateTagWithHttpInfo(createTagInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagInputObject** | [**CreateTagRequest**](CreateTagRequest.md) |  |  |

### Return type

[**CreateTagResponse**](CreateTagResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Tag created successfully. |  -  |
| **400** | Bad request - validation errors (e.g. invalid title format or tag already exists). |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtemplate"></a>
# **CreateTemplate**
> ResourceLinkResponse CreateTemplate (CreateTemplateRequest createTemplateInputObject)

Create a template

There are times when creating a new template makes sense (such as when targeting specific clients or improving your business strategies).  You can create new SMS templates for marketing purposes or SMS templates for business campaigns. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class CreateTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var createTemplateInputObject = new CreateTemplateRequest(); // CreateTemplateRequest | 

            try
            {
                // Create a template
                ResourceLinkResponse result = apiInstance.CreateTemplate(createTemplateInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.CreateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a template
    ApiResponse<ResourceLinkResponse> response = apiInstance.CreateTemplateWithHttpInfo(createTemplateInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.CreateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTemplateInputObject** | [**CreateTemplateRequest**](CreateTemplateRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Returned when the form has errors. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteallcontacts"></a>
# **DeleteAllContacts**
> void DeleteAllContacts ()

Delete contacts (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteAllContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Delete contacts (bulk)
                apiInstance.DeleteAllContacts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteAllContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete contacts (bulk)
    apiInstance.DeleteAllContactsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteAllContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletealloutboundmessages"></a>
# **DeleteAllOutboundMessages**
> void DeleteAllOutboundMessages ()

Delete all messages

Delete all messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteAllOutboundMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Delete all messages
                apiInstance.DeleteAllOutboundMessages();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteAllOutboundMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllOutboundMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all messages
    apiInstance.DeleteAllOutboundMessagesWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteAllOutboundMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteavatar"></a>
# **DeleteAvatar**
> void DeleteAvatar ()

Delete an avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Delete an avatar
                apiInstance.DeleteAvatar();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an avatar
    apiInstance.DeleteAvatarWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Avatar deleted with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletechatmessages"></a>
# **DeleteChatMessages**
> void DeleteChatMessages (int id, DeleteChatMessagesRequest deleteChatMessagesBulkInputObject)

Delete chat messages by ID(s)

Delete messages from chat by given message IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteChatMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var deleteChatMessagesBulkInputObject = new DeleteChatMessagesRequest(); // DeleteChatMessagesRequest | 

            try
            {
                // Delete chat messages by ID(s)
                apiInstance.DeleteChatMessages(id, deleteChatMessagesBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteChatMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChatMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete chat messages by ID(s)
    apiInstance.DeleteChatMessagesWithHttpInfo(id, deleteChatMessagesBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteChatMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **deleteChatMessagesBulkInputObject** | [**DeleteChatMessagesRequest**](DeleteChatMessagesRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletechatsbulk"></a>
# **DeleteChatsBulk**
> void DeleteChatsBulk (DeleteChatsBulkRequest deleteChatsBulkInputObject)

Delete chats (bulk)

Delete chats by given IDs or delete all chats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteChatsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteChatsBulkInputObject = new DeleteChatsBulkRequest(); // DeleteChatsBulkRequest | 

            try
            {
                // Delete chats (bulk)
                apiInstance.DeleteChatsBulk(deleteChatsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteChatsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChatsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete chats (bulk)
    apiInstance.DeleteChatsBulkWithHttpInfo(deleteChatsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteChatsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteChatsBulkInputObject** | [**DeleteChatsBulkRequest**](DeleteChatsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (int id)

Delete a contact

> This command removes your contact completely. If it was assigned or saved to a shared list, it will disappear from there too. If you only need to remove a contact from selected lists, use the Contact assignment command in the Lists section instead, rather than deleting the contact. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a contact
                apiInstance.DeleteContact(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a contact
    apiInstance.DeleteContactWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to delete a contact shared to a current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactavatar"></a>
# **DeleteContactAvatar**
> void DeleteContactAvatar (int id)

Delete an avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteContactAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete an avatar
                apiInstance.DeleteContactAvatar(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteContactAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an avatar
    apiInstance.DeleteContactAvatarWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteContactAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to delete a contact shared to a current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactnote"></a>
# **DeleteContactNote**
> void DeleteContactNote (int id)

Delete a contact note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteContactNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a contact note
                apiInstance.DeleteContactNote(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteContactNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a contact note
    apiInstance.DeleteContactNoteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteContactNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactnotesbulk"></a>
# **DeleteContactNotesBulk**
> void DeleteContactNotesBulk (int id, DeleteContactNotesBulkRequest deleteContactNotesBulkInputObject)

Delete contact notes (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteContactNotesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var deleteContactNotesBulkInputObject = new DeleteContactNotesBulkRequest(); // DeleteContactNotesBulkRequest | 

            try
            {
                // Delete contact notes (bulk)
                apiInstance.DeleteContactNotesBulk(id, deleteContactNotesBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteContactNotesBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactNotesBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete contact notes (bulk)
    apiInstance.DeleteContactNotesBulkWithHttpInfo(id, deleteContactNotesBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteContactNotesBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **deleteContactNotesBulkInputObject** | [**DeleteContactNotesBulkRequest**](DeleteContactNotesBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactsbyids"></a>
# **DeleteContactsByIds**
> void DeleteContactsByIds (DeleteContactsByIdsRequest deleteContactsByIdsInputObject)

Delete contacts by IDs (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteContactsByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteContactsByIdsInputObject = new DeleteContactsByIdsRequest(); // DeleteContactsByIdsRequest | 

            try
            {
                // Delete contacts by IDs (bulk)
                apiInstance.DeleteContactsByIds(deleteContactsByIdsInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteContactsByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactsByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete contacts by IDs (bulk)
    apiInstance.DeleteContactsByIdsWithHttpInfo(deleteContactsByIdsInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteContactsByIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteContactsByIdsInputObject** | [**DeleteContactsByIdsRequest**](DeleteContactsByIdsRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecontactsfromlist"></a>
# **DeleteContactsFromList**
> void DeleteContactsFromList (int id, DeleteContactsFromListRequest deleteContacsFromListObject)

Unassign contacts from a list

> When you remove contacts from a specific list, they will be deleted permanently, unless they are first saved in another list. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteContactsFromListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var deleteContacsFromListObject = new DeleteContactsFromListRequest(); // DeleteContactsFromListRequest | 

            try
            {
                // Unassign contacts from a list
                apiInstance.DeleteContactsFromList(id, deleteContacsFromListObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteContactsFromList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactsFromListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unassign contacts from a list
    apiInstance.DeleteContactsFromListWithHttpInfo(id, deleteContacsFromListObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteContactsFromListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **deleteContacsFromListObject** | [**DeleteContactsFromListRequest**](DeleteContactsFromListRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a list shared to the current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomfield"></a>
# **DeleteCustomField**
> void DeleteCustomField (int id)

Delete a custom field

> When a custom field is deleted, all the information that was added to contacts under this custom field will also be lost. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a custom field
                apiInstance.DeleteCustomField(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a custom field
    apiInstance.DeleteCustomFieldWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returned when deleted with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletededicatednumber"></a>
# **DeleteDedicatedNumber**
> void DeleteDedicatedNumber (int id)

Cancel a dedicated number subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteDedicatedNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Cancel a dedicated number subscription
                apiInstance.DeleteDedicatedNumber(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteDedicatedNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDedicatedNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel a dedicated number subscription
    apiInstance.DeleteDedicatedNumberWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteDedicatedNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The Dedicated number has been deleted with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteinboundmessage"></a>
# **DeleteInboundMessage**
> void DeleteInboundMessage (int id)

Delete a single inbound message

> Note: deleted inbound messages will disappear from TextMagic Online, chats, and any other place they are referenced.  So, be careful! 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteInboundMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | The unique numeric ID for the inbound message.

            try
            {
                // Delete a single inbound message
                apiInstance.DeleteInboundMessage(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteInboundMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInboundMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a single inbound message
    apiInstance.DeleteInboundMessageWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteInboundMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique numeric ID for the inbound message. |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteinboundmessagesbulk"></a>
# **DeleteInboundMessagesBulk**
> void DeleteInboundMessagesBulk (DeleteListsBulkRequest deleteInboundMessagesBulkInputObject)

Delete inbound messages (bulk)

> Note: deleted inbound messages will disappear from TextMagic Online, chats, and any other place they are referenced.  So, be careful! 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteInboundMessagesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteInboundMessagesBulkInputObject = new DeleteListsBulkRequest(); // DeleteListsBulkRequest | 

            try
            {
                // Delete inbound messages (bulk)
                apiInstance.DeleteInboundMessagesBulk(deleteInboundMessagesBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteInboundMessagesBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInboundMessagesBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete inbound messages (bulk)
    apiInstance.DeleteInboundMessagesBulkWithHttpInfo(deleteInboundMessagesBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteInboundMessagesBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteInboundMessagesBulkInputObject** | [**DeleteListsBulkRequest**](DeleteListsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelist"></a>
# **DeleteList**
> void DeleteList (int id)

Delete a list

This command has no parameters. If successful, this command will return the standard delete response (204 No Content); otherwise, a standard error response will be returned.  When you delete a list, the contacts in it are deleted as well, unless they were saved in another list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a list
                apiInstance.DeleteList(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a list
    apiInstance.DeleteListWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Returned when trying to remove a list associated with a signup form. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to remove a list shared to you. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelistavatar"></a>
# **DeleteListAvatar**
> void DeleteListAvatar (int id)

Delete an avatar for a list

Delete an avatar for a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteListAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete an avatar for a list
                apiInstance.DeleteListAvatar(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteListAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an avatar for a list
    apiInstance.DeleteListAvatarWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteListAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Avatar has been deleted with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a list shared to the current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelistcontactsbulk"></a>
# **DeleteListContactsBulk**
> void DeleteListContactsBulk (int id, UnblockContactsBulkRequest deleteListContactsBulkInputObject)

Delete contacts from a list (bulk)

Delete contacts from a list (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteListContactsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var deleteListContactsBulkInputObject = new UnblockContactsBulkRequest(); // UnblockContactsBulkRequest | 

            try
            {
                // Delete contacts from a list (bulk)
                apiInstance.DeleteListContactsBulk(id, deleteListContactsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteListContactsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListContactsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete contacts from a list (bulk)
    apiInstance.DeleteListContactsBulkWithHttpInfo(id, deleteListContactsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteListContactsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **deleteListContactsBulkInputObject** | [**UnblockContactsBulkRequest**](UnblockContactsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletelistsbulk"></a>
# **DeleteListsBulk**
> void DeleteListsBulk (DeleteListsBulkRequest deleteListsBulkInputObject)

Delete lists (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteListsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteListsBulkInputObject = new DeleteListsBulkRequest(); // DeleteListsBulkRequest | 

            try
            {
                // Delete lists (bulk)
                apiInstance.DeleteListsBulk(deleteListsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteListsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteListsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete lists (bulk)
    apiInstance.DeleteListsBulkWithHttpInfo(deleteListsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteListsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteListsBulkInputObject** | [**DeleteListsBulkRequest**](DeleteListsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemessagesession"></a>
# **DeleteMessageSession**
> void DeleteMessageSession (int id)

Delete a session

Delete a message session, together with all nested messages. > You will not be refunded for any deleted sent sessions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteMessageSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a session
                apiInstance.DeleteMessageSession(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteMessageSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMessageSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a session
    apiInstance.DeleteMessageSessionWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteMessageSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemessagesessionsbulk"></a>
# **DeleteMessageSessionsBulk**
> void DeleteMessageSessionsBulk (DeleteListsBulkRequest deleteMessageSessionsBulkInputObject)

Delete sessions (bulk)

Delete message sessions, together with all nested messages, by given ID(s) or delete all message sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteMessageSessionsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteMessageSessionsBulkInputObject = new DeleteListsBulkRequest(); // DeleteListsBulkRequest | 

            try
            {
                // Delete sessions (bulk)
                apiInstance.DeleteMessageSessionsBulk(deleteMessageSessionsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteMessageSessionsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMessageSessionsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete sessions (bulk)
    apiInstance.DeleteMessageSessionsBulkWithHttpInfo(deleteMessageSessionsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteMessageSessionsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteMessageSessionsBulkInputObject** | [**DeleteListsBulkRequest**](DeleteListsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteoutboundmessage"></a>
# **DeleteOutboundMessage**
> void DeleteOutboundMessage (int id)

Delete message

Delete a single message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteOutboundMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete message
                apiInstance.DeleteOutboundMessage(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteOutboundMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOutboundMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete message
    apiInstance.DeleteOutboundMessageWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteOutboundMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteoutboundmessagesbulk"></a>
# **DeleteOutboundMessagesBulk**
> void DeleteOutboundMessagesBulk (DeleteOutboundMessagesBulkRequest deleteOutboundMessagesBulkInputObject)

Delete messages (bulk)

Delete outbound messages by the given ID(s) or delete all outbound messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteOutboundMessagesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteOutboundMessagesBulkInputObject = new DeleteOutboundMessagesBulkRequest(); // DeleteOutboundMessagesBulkRequest | 

            try
            {
                // Delete messages (bulk)
                apiInstance.DeleteOutboundMessagesBulk(deleteOutboundMessagesBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteOutboundMessagesBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOutboundMessagesBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete messages (bulk)
    apiInstance.DeleteOutboundMessagesBulkWithHttpInfo(deleteOutboundMessagesBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteOutboundMessagesBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteOutboundMessagesBulkInputObject** | [**DeleteOutboundMessagesBulkRequest**](DeleteOutboundMessagesBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletescheduledmessage"></a>
# **DeleteScheduledMessage**
> void DeleteScheduledMessage (int id)

Delete a single scheduled message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteScheduledMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a single scheduled message
                apiInstance.DeleteScheduledMessage(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteScheduledMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScheduledMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a single scheduled message
    apiInstance.DeleteScheduledMessageWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteScheduledMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletescheduledmessagesbulk"></a>
# **DeleteScheduledMessagesBulk**
> void DeleteScheduledMessagesBulk (DeleteScheduledMessagesBulkRequest deleteScheduledMessagesBulkInputObject)

Delete scheduled messages (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteScheduledMessagesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteScheduledMessagesBulkInputObject = new DeleteScheduledMessagesBulkRequest(); // DeleteScheduledMessagesBulkRequest | 

            try
            {
                // Delete scheduled messages (bulk)
                apiInstance.DeleteScheduledMessagesBulk(deleteScheduledMessagesBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteScheduledMessagesBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScheduledMessagesBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete scheduled messages (bulk)
    apiInstance.DeleteScheduledMessagesBulkWithHttpInfo(deleteScheduledMessagesBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteScheduledMessagesBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteScheduledMessagesBulkInputObject** | [**DeleteScheduledMessagesBulkRequest**](DeleteScheduledMessagesBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesenderid"></a>
# **DeleteSenderId**
> void DeleteSenderId (int id)

Delete a Sender ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteSenderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a Sender ID
                apiInstance.DeleteSenderId(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteSenderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSenderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Sender ID
    apiInstance.DeleteSenderIdWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteSenderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful delete chat. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetemplate"></a>
# **DeleteTemplate**
> void DeleteTemplate (int id)

Delete a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Delete a template
                apiInstance.DeleteTemplate(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a template
    apiInstance.DeleteTemplateWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetemplatesbulk"></a>
# **DeleteTemplatesBulk**
> void DeleteTemplatesBulk (DeleteContactNotesBulkRequest deleteTemplatesBulkInputObject)

Delete templates (bulk)

Delete templates by given IDs or delete all templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DeleteTemplatesBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var deleteTemplatesBulkInputObject = new DeleteContactNotesBulkRequest(); // DeleteContactNotesBulkRequest | 

            try
            {
                // Delete templates (bulk)
                apiInstance.DeleteTemplatesBulk(deleteTemplatesBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DeleteTemplatesBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTemplatesBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete templates (bulk)
    apiInstance.DeleteTemplatesBulkWithHttpInfo(deleteTemplatesBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DeleteTemplatesBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteTemplatesBulkInputObject** | [**DeleteContactNotesBulkRequest**](DeleteContactNotesBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="docarrierlookup"></a>
# **DoCarrierLookup**
> DoCarrierLookupResponse DoCarrierLookup (string phone, string country = null)

Carrier Lookup

This API call allows you to retrieve additional information about a phone number: region-specific phone number formatting, carrier, phone type (landline/mobile) and country information.  > Numbers must be checked one by one. You cannot check multiple numbers in one request.   

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DoCarrierLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var phone = 447860021130;  // string | Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164) or in [National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers). 
            var country = GB;  // string | This option must be specified only if the phone number is in a **[National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers)**.  (optional) 

            try
            {
                // Carrier Lookup
                DoCarrierLookupResponse result = apiInstance.DoCarrierLookup(phone, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DoCarrierLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DoCarrierLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Carrier Lookup
    ApiResponse<DoCarrierLookupResponse> response = apiInstance.DoCarrierLookupWithHttpInfo(phone, country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DoCarrierLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | Phone number in [E.164 format](https://en.wikipedia.org/wiki/E.164) or in [National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers).  |  |
| **country** | **string** | This option must be specified only if the phone number is in a **[National format](https://en.wikipedia.org/wiki/National_conventions_for_writing_telephone_numbers)**.  | [optional]  |

### Return type

[**DoCarrierLookupResponse**](DoCarrierLookupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **429** | Returned when the number of queries per second is too high. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="doemaillookup"></a>
# **DoEmailLookup**
> DoEmailLookupResponse DoEmailLookup (string email)

Email Lookup

To get more details about an email address or to check whether it is a valid email or not, you can use the Email Lookup command. To upload and check emails in bulk, please use our [Web app](https://my.textmagic.com/online/email-lookup/).  This API call allows you to retrieve additional information about an email address, such as mailbox detection, syntax checks, DNS validation, deliverability status, and many more helpful values (see the table below).  > Emails must be checked one by one. You cannot check multiple emails in one request. To upload and check emails in bulk, please use our [Web app](https://my.textmagic.com/online/email-lookup/).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class DoEmailLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var email = john@sample.com;  // string | Email address.

            try
            {
                // Email Lookup
                DoEmailLookupResponse result = apiInstance.DoEmailLookup(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.DoEmailLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DoEmailLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Email Lookup
    ApiResponse<DoEmailLookupResponse> response = apiInstance.DoEmailLookupWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.DoEmailLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email address. |  |

### Return type

[**DoEmailLookupResponse**](DoEmailLookupResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallbulksessions"></a>
# **GetAllBulkSessions**
> GetAllBulkSessionsPaginatedResponse GetAllBulkSessions (int? page = null, int? limit = null)

Get all bulk sessions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllBulkSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get all bulk sessions
                GetAllBulkSessionsPaginatedResponse result = apiInstance.GetAllBulkSessions(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllBulkSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllBulkSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all bulk sessions
    ApiResponse<GetAllBulkSessionsPaginatedResponse> response = apiInstance.GetAllBulkSessionsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllBulkSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetAllBulkSessionsPaginatedResponse**](GetAllBulkSessionsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallchats"></a>
# **GetAllChats**
> GetAllChatsPaginatedResponse GetAllChats (string status = null, int? page = null, int? limit = null, string orderBy = null, int? voice = null, int? flat = null)

Get all chats

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllChatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var status = a;  // string | Fetch only (a)ctive, (c)losed or (d)eleted chats. (optional) 
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var voice = 0;  // int? | Fetch results with voice calls. (optional)  (default to 0)
            var flat = 1;  // int? | Should additional contact info be included? (optional)  (default to 0)

            try
            {
                // Get all chats
                GetAllChatsPaginatedResponse result = apiInstance.GetAllChats(status, page, limit, orderBy, voice, flat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllChats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllChatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all chats
    ApiResponse<GetAllChatsPaginatedResponse> response = apiInstance.GetAllChatsWithHttpInfo(status, page, limit, orderBy, voice, flat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllChatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string** | Fetch only (a)ctive, (c)losed or (d)eleted chats. | [optional]  |
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **voice** | **int?** | Fetch results with voice calls. | [optional] [default to 0] |
| **flat** | **int?** | Should additional contact info be included? | [optional] [default to 0] |

### Return type

[**GetAllChatsPaginatedResponse**](GetAllChatsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallinboundmessages"></a>
# **GetAllInboundMessages**
> GetAllInboundMessagesPaginatedResponse GetAllInboundMessages (int? page = null, int? limit = null, string orderBy = null, string direction = null)

Get all inbound messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllInboundMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Get all inbound messages
                GetAllInboundMessagesPaginatedResponse result = apiInstance.GetAllInboundMessages(page, limit, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllInboundMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllInboundMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all inbound messages
    ApiResponse<GetAllInboundMessagesPaginatedResponse> response = apiInstance.GetAllInboundMessagesWithHttpInfo(page, limit, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllInboundMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**GetAllInboundMessagesPaginatedResponse**](GetAllInboundMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallmessagesessions"></a>
# **GetAllMessageSessions**
> GetAllMessageSessionsPaginatedResponse GetAllMessageSessions (int? page = null, int? limit = null)

Get all sessions

Get all message sending sessions. > This list contains all of your sessions, including those which were sent but not via API 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllMessageSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get all sessions
                GetAllMessageSessionsPaginatedResponse result = apiInstance.GetAllMessageSessions(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllMessageSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllMessageSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all sessions
    ApiResponse<GetAllMessageSessionsPaginatedResponse> response = apiInstance.GetAllMessageSessionsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllMessageSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetAllMessageSessionsPaginatedResponse**](GetAllMessageSessionsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalloutboundmessages"></a>
# **GetAllOutboundMessages**
> GetAllOutboundMessagesPaginatedResponse GetAllOutboundMessages (int? page = null, int? limit = null, int? lastId = null)

Get all messages

Get all user oubound messages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllOutboundMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var lastId = 56;  // int? | Filter results by ID, selecting all values lesser than the specified ID. Note that the \\'page\\' parameter is ignored when \\'lastId\\' is specified. (optional) 

            try
            {
                // Get all messages
                GetAllOutboundMessagesPaginatedResponse result = apiInstance.GetAllOutboundMessages(page, limit, lastId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllOutboundMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllOutboundMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all messages
    ApiResponse<GetAllOutboundMessagesPaginatedResponse> response = apiInstance.GetAllOutboundMessagesWithHttpInfo(page, limit, lastId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllOutboundMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **lastId** | **int?** | Filter results by ID, selecting all values lesser than the specified ID. Note that the \\&#39;page\\&#39; parameter is ignored when \\&#39;lastId\\&#39; is specified. | [optional]  |

### Return type

[**GetAllOutboundMessagesPaginatedResponse**](GetAllOutboundMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallscheduledmessages"></a>
# **GetAllScheduledMessages**
> GetAllScheduledMessagesPaginatedResponse GetAllScheduledMessages (int? page = null, int? limit = null, string status = null, string orderBy = null, string direction = null)

Get all scheduled messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllScheduledMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var status = "a";  // string | Fetch schedules with a specific status: a - actual, c - completed, x - all. (optional)  (default to x)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Get all scheduled messages
                GetAllScheduledMessagesPaginatedResponse result = apiInstance.GetAllScheduledMessages(page, limit, status, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllScheduledMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllScheduledMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all scheduled messages
    ApiResponse<GetAllScheduledMessagesPaginatedResponse> response = apiInstance.GetAllScheduledMessagesWithHttpInfo(page, limit, status, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllScheduledMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **status** | **string** | Fetch schedules with a specific status: a - actual, c - completed, x - all. | [optional] [default to x] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**GetAllScheduledMessagesPaginatedResponse**](GetAllScheduledMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltemplates"></a>
# **GetAllTemplates**
> GetAllTemplatesPaginatedResponse GetAllTemplates (int? page = null, int? limit = null)

Get all templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAllTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional) 
            var limit = 10;  // int? | The number of results per page. (optional) 

            try
            {
                // Get all templates
                GetAllTemplatesPaginatedResponse result = apiInstance.GetAllTemplates(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAllTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all templates
    ApiResponse<GetAllTemplatesPaginatedResponse> response = apiInstance.GetAllTemplatesWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAllTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional]  |
| **limit** | **int?** | The number of results per page. | [optional]  |

### Return type

[**GetAllTemplatesPaginatedResponse**](GetAllTemplatesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getavailablededicatednumbers"></a>
# **GetAvailableDedicatedNumbers**
> GetAvailableDedicatedNumbersResponse GetAvailableDedicatedNumbers (string country, int? prefix = null, int? tollfree = null)

Find dedicated numbers available for purchase

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAvailableDedicatedNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var country = GB;  // string | The 2-letter dedicated number country ISO code.
            var prefix = 447155;  // int? | Desired number prefix. Should include the country code (i.e. 447 for UK phone number format). Leave blank to get all the available numbers for the specified country. (optional) 
            var tollfree = 0;  // int? | Should we show only tollfree numbers (tollfree available only for US). (optional)  (default to 0)

            try
            {
                // Find dedicated numbers available for purchase
                GetAvailableDedicatedNumbersResponse result = apiInstance.GetAvailableDedicatedNumbers(country, prefix, tollfree);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAvailableDedicatedNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailableDedicatedNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find dedicated numbers available for purchase
    ApiResponse<GetAvailableDedicatedNumbersResponse> response = apiInstance.GetAvailableDedicatedNumbersWithHttpInfo(country, prefix, tollfree);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAvailableDedicatedNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | The 2-letter dedicated number country ISO code. |  |
| **prefix** | **int?** | Desired number prefix. Should include the country code (i.e. 447 for UK phone number format). Leave blank to get all the available numbers for the specified country. | [optional]  |
| **tollfree** | **int?** | Should we show only tollfree numbers (tollfree available only for US). | [optional] [default to 0] |

### Return type

[**GetAvailableDedicatedNumbersResponse**](GetAvailableDedicatedNumbersResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of available to buy dedicated numbers. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getavailablesendersettingoptions"></a>
# **GetAvailableSenderSettingOptions**
> GetAvailableSenderSettingOptionsResponse GetAvailableSenderSettingOptions (string country = null)

Get available sender settings

Get all available sender setting options which can be used in the \"from\" parameter of the POST messages method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetAvailableSenderSettingOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var country = US;  // string | The 2-letter ISO country ID. If not specified, it returns all the available sender settings. (optional) 

            try
            {
                // Get available sender settings
                GetAvailableSenderSettingOptionsResponse result = apiInstance.GetAvailableSenderSettingOptions(country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetAvailableSenderSettingOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailableSenderSettingOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get available sender settings
    ApiResponse<GetAvailableSenderSettingOptionsResponse> response = apiInstance.GetAvailableSenderSettingOptionsWithHttpInfo(country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetAvailableSenderSettingOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | The 2-letter ISO country ID. If not specified, it returns all the available sender settings. | [optional]  |

### Return type

[**GetAvailableSenderSettingOptionsResponse**](GetAvailableSenderSettingOptionsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available sender setting options returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbalancenotificationoptions"></a>
# **GetBalanceNotificationOptions**
> GetBalanceNotificationOptionsResponse GetBalanceNotificationOptions ()

Returns the list of available balance options which can be used as a bound to determine when to send email to user with low balance notification. See https://my.textmagic.com/online/account/notifications/balance

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetBalanceNotificationOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Returns the list of available balance options which can be used as a bound to determine when to send email to user with low balance notification. See https://my.textmagic.com/online/account/notifications/balance
                GetBalanceNotificationOptionsResponse result = apiInstance.GetBalanceNotificationOptions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetBalanceNotificationOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceNotificationOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the list of available balance options which can be used as a bound to determine when to send email to user with low balance notification. See https://my.textmagic.com/online/account/notifications/balance
    ApiResponse<GetBalanceNotificationOptionsResponse> response = apiInstance.GetBalanceNotificationOptionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetBalanceNotificationOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetBalanceNotificationOptionsResponse**](GetBalanceNotificationOptionsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when the list of available balance options have been received with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbalancenotificationsettings"></a>
# **GetBalanceNotificationSettings**
> GetBalanceNotificationSettingsResponse GetBalanceNotificationSettings ()

Get balance notification settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetBalanceNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Get balance notification settings
                GetBalanceNotificationSettingsResponse result = apiInstance.GetBalanceNotificationSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetBalanceNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBalanceNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get balance notification settings
    ApiResponse<GetBalanceNotificationSettingsResponse> response = apiInstance.GetBalanceNotificationSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetBalanceNotificationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetBalanceNotificationSettingsResponse**](GetBalanceNotificationSettingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getblockedcontacts"></a>
# **GetBlockedContacts**
> GetBlockedContactsPaginatedResponse GetBlockedContacts (int? page = null, int? limit = null, string query = null, string orderBy = null, string direction = null)

Get blocked contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetBlockedContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var query = "query_example";  // string | Find blocked contacts by specified search query. (optional) 
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Get blocked contacts
                GetBlockedContactsPaginatedResponse result = apiInstance.GetBlockedContacts(page, limit, query, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetBlockedContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBlockedContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get blocked contacts
    ApiResponse<GetBlockedContactsPaginatedResponse> response = apiInstance.GetBlockedContactsWithHttpInfo(page, limit, query, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetBlockedContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **query** | **string** | Find blocked contacts by specified search query. | [optional]  |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**GetBlockedContactsPaginatedResponse**](GetBlockedContactsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbulksession"></a>
# **GetBulkSession**
> BulkSession GetBulkSession (int id)

Get bulk session status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetBulkSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get bulk session status
                BulkSession result = apiInstance.GetBulkSession(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetBulkSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBulkSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get bulk session status
    ApiResponse<BulkSession> response = apiInstance.GetBulkSessionWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetBulkSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**BulkSession**](BulkSession.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcallbacksettings"></a>
# **GetCallbackSettings**
> GetCallbackSettingsResponse GetCallbackSettings ()

Fetch callback URL settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetCallbackSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Fetch callback URL settings
                GetCallbackSettingsResponse result = apiInstance.GetCallbackSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetCallbackSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCallbackSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch callback URL settings
    ApiResponse<GetCallbackSettingsResponse> response = apiInstance.GetCallbackSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetCallbackSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetCallbackSettingsResponse**](GetCallbackSettingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Callback settings has been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchat"></a>
# **GetChat**
> Chat GetChat (int id)

Get a single chat

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetChatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get a single chat
                Chat result = apiInstance.GetChat(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetChat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single chat
    ApiResponse<Chat> response = apiInstance.GetChatWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetChatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**Chat**](Chat.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchatbyphone"></a>
# **GetChatByPhone**
> Chat GetChatByPhone (string phone, int? upsert = null, int? reopen = null)

Find chats by phone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetChatByPhoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var phone = 447860021130;  // string | 
            var upsert = 0;  // int? | Create a new chat if not found. (optional)  (default to 0)
            var reopen = 0;  // int? | Reopen chat if found or do not change status. (optional)  (default to 0)

            try
            {
                // Find chats by phone
                Chat result = apiInstance.GetChatByPhone(phone, upsert, reopen);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetChatByPhone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChatByPhoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find chats by phone
    ApiResponse<Chat> response = apiInstance.GetChatByPhoneWithHttpInfo(phone, upsert, reopen);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetChatByPhoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** |  |  |
| **upsert** | **int?** | Create a new chat if not found. | [optional] [default to 0] |
| **reopen** | **int?** | Reopen chat if found or do not change status. | [optional] [default to 0] |

### Return type

[**Chat**](Chat.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchatmessages"></a>
# **GetChatMessages**
> GetChatMessagesPaginatedResponse GetChatMessages (int id, int? page = null, int? limit = null, string query = null, string start = null, string end = null, string direction = null, int? voice = null, int? includeNotes = null)

Get chat messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetChatMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var query = "query_example";  // string | Find messages by specified search query. (optional) 
            var start = "start_example";  // string | Return messages since specified timestamp only. Required when `end` parameter specified. (optional) 
            var end = "end_example";  // string | Return messages up to specified timestamp only. Required when `start` parameter specified. (optional) 
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)
            var voice = 0;  // int? | Fetch results with voice calls. (optional)  (default to 0)
            var includeNotes = 0;  // int? | Fetch results with messenger notes. (optional)  (default to 0)

            try
            {
                // Get chat messages
                GetChatMessagesPaginatedResponse result = apiInstance.GetChatMessages(id, page, limit, query, start, end, direction, voice, includeNotes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetChatMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChatMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get chat messages
    ApiResponse<GetChatMessagesPaginatedResponse> response = apiInstance.GetChatMessagesWithHttpInfo(id, page, limit, query, start, end, direction, voice, includeNotes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetChatMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **query** | **string** | Find messages by specified search query. | [optional]  |
| **start** | **string** | Return messages since specified timestamp only. Required when &#x60;end&#x60; parameter specified. | [optional]  |
| **end** | **string** | Return messages up to specified timestamp only. Required when &#x60;start&#x60; parameter specified. | [optional]  |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |
| **voice** | **int?** | Fetch results with voice calls. | [optional] [default to 0] |
| **includeNotes** | **int?** | Fetch results with messenger notes. | [optional] [default to 0] |

### Return type

[**GetChatMessagesPaginatedResponse**](GetChatMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Returned when invalid phone number specified. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontact"></a>
# **GetContact**
> Contact GetContact (int id)

Get the details of a specific contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | Contact ID.

            try
            {
                // Get the details of a specific contact
                Contact result = apiInstance.GetContact(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific contact
    ApiResponse<Contact> response = apiInstance.GetContactWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Contact ID. |  |

### Return type

[**Contact**](Contact.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact data received with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactbyphone"></a>
# **GetContactByPhone**
> Contact GetContactByPhone (string phone)

Get the details of a specific contact by phone number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactByPhoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var phone = 447860021130;  // string | 

            try
            {
                // Get the details of a specific contact by phone number
                Contact result = apiInstance.GetContactByPhone(phone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactByPhone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactByPhoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific contact by phone number
    ApiResponse<Contact> response = apiInstance.GetContactByPhoneWithHttpInfo(phone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactByPhoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** |  |  |

### Return type

[**Contact**](Contact.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contact data has been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactifblocked"></a>
# **GetContactIfBlocked**
> Contact GetContactIfBlocked (string phone)

Check if a phone number is blocked

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactIfBlockedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var phone = 447860021130;  // string | Phone number to check.

            try
            {
                // Check if a phone number is blocked
                Contact result = apiInstance.GetContactIfBlocked(phone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactIfBlocked: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactIfBlockedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if a phone number is blocked
    ApiResponse<Contact> response = apiInstance.GetContactIfBlockedWithHttpInfo(phone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactIfBlockedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phone** | **string** | Phone number to check. |  |

### Return type

[**Contact**](Contact.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when contact is blocked. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | When the contact is not blocked. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactimportsessionprogress"></a>
# **GetContactImportSessionProgress**
> GetContactImportSessionProgressResponse GetContactImportSessionProgress (int id)

Check import progress

Get contact import session progress.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactImportSessionProgressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Check import progress
                GetContactImportSessionProgressResponse result = apiInstance.GetContactImportSessionProgress(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactImportSessionProgress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactImportSessionProgressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check import progress
    ApiResponse<GetContactImportSessionProgressResponse> response = apiInstance.GetContactImportSessionProgressWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactImportSessionProgressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**GetContactImportSessionProgressResponse**](GetContactImportSessionProgressResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactnote"></a>
# **GetContactNote**
> ContactNote GetContactNote (int id)

Get a contact note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get a contact note
                ContactNote result = apiInstance.GetContactNote(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a contact note
    ApiResponse<ContactNote> response = apiInstance.GetContactNoteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**ContactNote**](ContactNote.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactnotes"></a>
# **GetContactNotes**
> GetContactNotesPaginatedResponse GetContactNotes (int id, int? page = null, int? limit = null)

Fetch notes assigned to a given contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Fetch notes assigned to a given contact
                GetContactNotesPaginatedResponse result = apiInstance.GetContactNotes(id, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch notes assigned to a given contact
    ApiResponse<GetContactNotesPaginatedResponse> response = apiInstance.GetContactNotesWithHttpInfo(id, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetContactNotesPaginatedResponse**](GetContactNotesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontacts"></a>
# **GetContacts**
> GetContactsPaginatedResponse GetContacts (int? page = null, int? limit = null, int? shared = null, string orderBy = null, string direction = null)

Get all contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var shared = 0;  // int? | Should shared contacts be included? (optional)  (default to 0)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Get all contacts
                GetContactsPaginatedResponse result = apiInstance.GetContacts(page, limit, shared, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all contacts
    ApiResponse<GetContactsPaginatedResponse> response = apiInstance.GetContactsWithHttpInfo(page, limit, shared, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **shared** | **int?** | Should shared contacts be included? | [optional] [default to 0] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**GetContactsPaginatedResponse**](GetContactsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested contacts have been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactsautocomplete"></a>
# **GetContactsAutocomplete**
> List&lt;GetContactsAutocompleteResponseItem&gt; GetContactsAutocomplete (string query, int? limit = null, int? lists = null)

Get contacts autocomplete suggestions

Get contacts autocomplete suggestions by given search terms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactsAutocompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var query = A;  // string | Find recipients by specified search query.
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var lists = 0;  // int? | Should lists be returned or not? (optional)  (default to 0)

            try
            {
                // Get contacts autocomplete suggestions
                List<GetContactsAutocompleteResponseItem> result = apiInstance.GetContactsAutocomplete(query, limit, lists);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactsAutocomplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactsAutocompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contacts autocomplete suggestions
    ApiResponse<List<GetContactsAutocompleteResponseItem>> response = apiInstance.GetContactsAutocompleteWithHttpInfo(query, limit, lists);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactsAutocompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Find recipients by specified search query. |  |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **lists** | **int?** | Should lists be returned or not? | [optional] [default to 0] |

### Return type

[**List&lt;GetContactsAutocompleteResponseItem&gt;**](GetContactsAutocompleteResponseItem.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Autocomplete data has been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontactsbylistid"></a>
# **GetContactsByListId**
> GetContactsByListIdPaginatedResponse GetContactsByListId (int id, int? page = null, int? limit = null, string orderBy = null, string direction = null)

Get all contacts in a list

A useful synonym for the \"contacts/search\" command with the provided \"listId\" parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetContactsByListIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | Given group ID.
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Get all contacts in a list
                GetContactsByListIdPaginatedResponse result = apiInstance.GetContactsByListId(id, page, limit, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetContactsByListId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactsByListIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all contacts in a list
    ApiResponse<GetContactsByListIdPaginatedResponse> response = apiInstance.GetContactsByListIdWithHttpInfo(id, page, limit, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetContactsByListIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Given group ID. |  |
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**GetContactsByListIdPaginatedResponse**](GetContactsByListIdPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcountries"></a>
# **GetCountries**
> List&lt;Country&gt; GetCountries ()

Get countries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetCountriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Get countries
                List<Country> result = apiInstance.GetCountries();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetCountries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCountriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get countries
    ApiResponse<List<Country>> response = apiInstance.GetCountriesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetCountriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Country&gt;**](Country.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcurrentuser"></a>
# **GetCurrentUser**
> User GetCurrentUser ()

Get current account information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Get current account information
                User result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetCurrentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get current account information
    ApiResponse<User> response = apiInstance.GetCurrentUserWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetCurrentUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**User**](User.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomfield"></a>
# **GetCustomField**
> UserCustomField GetCustomField (int id)

Get the details of a specific custom field

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get the details of a specific custom field
                UserCustomField result = apiInstance.GetCustomField(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific custom field
    ApiResponse<UserCustomField> response = apiInstance.GetCustomFieldWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**UserCustomField**](UserCustomField.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomfields"></a>
# **GetCustomFields**
> GetCustomFieldsPaginatedResponse GetCustomFields (int? page = null, int? limit = null)

Get all custom fields

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetCustomFieldsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get all custom fields
                GetCustomFieldsPaginatedResponse result = apiInstance.GetCustomFields(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetCustomFields: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomFieldsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all custom fields
    ApiResponse<GetCustomFieldsPaginatedResponse> response = apiInstance.GetCustomFieldsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetCustomFieldsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetCustomFieldsPaginatedResponse**](GetCustomFieldsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested custom fields have been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdedicatednumber"></a>
# **GetDedicatedNumber**
> UsersInbound GetDedicatedNumber (int id)

Get the details of a specific dedicated number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetDedicatedNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get the details of a specific dedicated number
                UsersInbound result = apiInstance.GetDedicatedNumber(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetDedicatedNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDedicatedNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific dedicated number
    ApiResponse<UsersInbound> response = apiInstance.GetDedicatedNumberWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetDedicatedNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**UsersInbound**](UsersInbound.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested dedicated number data returned with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getemailsenders"></a>
# **GetEmailSenders**
> GetEmailSendersResponse GetEmailSenders (int? domainId = null)

Get list of email senders

Retrieves a list of configured email senders available for creating email campaigns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetEmailSendersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var domainId = 56;  // int? | Filter email senders by specific domain ID. (optional) 

            try
            {
                // Get list of email senders
                GetEmailSendersResponse result = apiInstance.GetEmailSenders(domainId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetEmailSenders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailSendersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of email senders
    ApiResponse<GetEmailSendersResponse> response = apiInstance.GetEmailSendersWithHttpInfo(domainId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetEmailSendersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domainId** | **int?** | Filter email senders by specific domain ID. | [optional]  |

### Return type

[**GetEmailSendersResponse**](GetEmailSendersResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email senders retrieved successfully. |  -  |
| **400** | Bad request - invalid query parameters. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfavorites"></a>
# **GetFavorites**
> GetFavoritesPaginatedResponse GetFavorites (int? page = null, int? limit = null, string query = null)

Get favorite contacts and lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetFavoritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var query = A;  // string | Find contacts or lists by specified search query. (optional) 

            try
            {
                // Get favorite contacts and lists
                GetFavoritesPaginatedResponse result = apiInstance.GetFavorites(page, limit, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetFavorites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get favorite contacts and lists
    ApiResponse<GetFavoritesPaginatedResponse> response = apiInstance.GetFavoritesWithHttpInfo(page, limit, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetFavoritesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **query** | **string** | Find contacts or lists by specified search query. | [optional]  |

### Return type

[**GetFavoritesPaginatedResponse**](GetFavoritesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Favorite entities have been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinboundmessage"></a>
# **GetInboundMessage**
> MessageIn GetInboundMessage (int id)

Get a single inbound message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetInboundMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1782832;  // int | The unique numeric ID for the inbound message.

            try
            {
                // Get a single inbound message
                MessageIn result = apiInstance.GetInboundMessage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetInboundMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboundMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single inbound message
    ApiResponse<MessageIn> response = apiInstance.GetInboundMessageWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetInboundMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The unique numeric ID for the inbound message. |  |

### Return type

[**MessageIn**](MessageIn.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinboundmessagesnotificationsettings"></a>
# **GetInboundMessagesNotificationSettings**
> GetInboundMessagesNotificationSettingsResponse GetInboundMessagesNotificationSettings ()

Get inbound messages notification settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetInboundMessagesNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Get inbound messages notification settings
                GetInboundMessagesNotificationSettingsResponse result = apiInstance.GetInboundMessagesNotificationSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetInboundMessagesNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboundMessagesNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get inbound messages notification settings
    ApiResponse<GetInboundMessagesNotificationSettingsResponse> response = apiInstance.GetInboundMessagesNotificationSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetInboundMessagesNotificationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetInboundMessagesNotificationSettingsResponse**](GetInboundMessagesNotificationSettingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinvoices"></a>
# **GetInvoices**
> GetInvoicesPaginatedResponse GetInvoices (int? page = null, int? limit = null)

Get all invoices

With the TextMagic API, you can check the invoices and transactions for your account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetInvoicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get all invoices
                GetInvoicesPaginatedResponse result = apiInstance.GetInvoices(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all invoices
    ApiResponse<GetInvoicesPaginatedResponse> response = apiInstance.GetInvoicesWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetInvoicesPaginatedResponse**](GetInvoicesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when the current user is not allowed to manage invoices. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlist"></a>
# **GetList**
> List GetList (int id)

Get the details of a specific list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get the details of a specific list
                List result = apiInstance.GetList(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific list
    ApiResponse<List> response = apiInstance.GetListWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

**List**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlistcontactsids"></a>
# **GetListContactsIds**
> List&lt;int&gt; GetListContactsIds (int id)

Get all contact IDs in a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetListContactsIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get all contact IDs in a list
                List<int> result = apiInstance.GetListContactsIds(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetListContactsIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListContactsIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all contact IDs in a list
    ApiResponse<List<int>> response = apiInstance.GetListContactsIdsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetListContactsIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

**List<int>**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlists"></a>
# **GetLists**
> GetListsPaginatedResponse GetLists (int? page = null, int? limit = null, string orderBy = null, string direction = null, int? favoriteOnly = null, int? onlyMine = null)

Get all lists

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | The current fetched page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)
            var favoriteOnly = 0;  // int? | Return only favorited lists. (optional)  (default to 0)
            var onlyMine = 0;  // int? | Return only current user lists. (optional)  (default to 0)

            try
            {
                // Get all lists
                GetListsPaginatedResponse result = apiInstance.GetLists(page, limit, orderBy, direction, favoriteOnly, onlyMine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all lists
    ApiResponse<GetListsPaginatedResponse> response = apiInstance.GetListsWithHttpInfo(page, limit, orderBy, direction, favoriteOnly, onlyMine);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | The current fetched page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |
| **favoriteOnly** | **int?** | Return only favorited lists. | [optional] [default to 0] |
| **onlyMine** | **int?** | Return only current user lists. | [optional] [default to 0] |

### Return type

[**GetListsPaginatedResponse**](GetListsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlistsofcontact"></a>
# **GetListsOfContact**
> GetListsOfContactPaginatedResponse GetListsOfContact (int id, int? page = null, int? limit = null)

Get a contact's lists

Get all the lists in which a contact is included.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetListsOfContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get a contact's lists
                GetListsOfContactPaginatedResponse result = apiInstance.GetListsOfContact(id, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetListsOfContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetListsOfContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a contact's lists
    ApiResponse<GetListsOfContactPaginatedResponse> response = apiInstance.GetListsOfContactWithHttpInfo(id, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetListsOfContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetListsOfContactPaginatedResponse**](GetListsOfContactPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagepreview"></a>
# **GetMessagePreview**
> GetMessagePreviewResponse GetMessagePreview (string text = null, int? templateId = null, int? sendingTime = null, string sendingDateTime = null, string sendingTimezone = null, string contacts = null, string lists = null, string phones = null, int? cutExtra = null, int? partsCount = null, int? referenceId = null, string from = null, string rule = null, int? createChat = null, int? tts = null, int? local = null, string localCountry = null)

Preview message

Get a messages preview (with dynamic fields merged) of up to 100 messages per session. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessagePreviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var text = Test message test;  // string | Message text. Required if **template_id** is not set. (optional) 
            var templateId = 1;  // int? | Template used instead of message text. Required if **text** is not set. (optional) 
            var sendingTime = 1565606455;  // int? | DEPRECATED, consider using sendingDateTime and sendingTimezone parameters instead: Optional (required with rrule set). Message sending time is in unix timestamp format. Default is now. (optional) 
            var sendingDateTime = 2020-05-27 13:02:33;  // string | Sending time is in Y-m-d H:i:s format (e.g. 2016-05-27 13:02:33). This time is relative to the sendingTimezone. (optional) 
            var sendingTimezone = America/Buenos_Aires;  // string | The ID or ISO-name of the timezone used for sending when the sendingDateTime parameter is set, e.g. if you specify sendingDateTime = \\\"2016-05-27 13:02:33\\\" and sendingTimezone = \\\"America/Buenos_Aires\\\", your message will be sent on May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is the account timezone. (optional) 
            var contacts = 1,2,3,4;  // string | Comma-separated array of contact resources id message will be sent to. (optional) 
            var lists = 1,2,3,4;  // string | Comma-separated array of list resources id message will be sent to. (optional) 
            var phones = 447860021130,447860021131;  // string | Comma-separated array of E.164 phone numbers message will be sent to. (optional) 
            var cutExtra = 0;  // int? | Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead. (optional)  (default to 0)
            var partsCount = 6;  // int? | Maximum message parts count (Textmagic allows sending of 1 to 6 message parts). (optional)  (default to 6)
            var referenceId = 1;  // int? | Custom message reference id which can be used in your application infrastructure. (optional) 
            var from = Test Sender ID;  // string | One of the allowed Sender ID (phone number or alphanumeric sender ID). If the specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs). (optional) 
            var rule = FREQ=YEARLY;BYMONTH=1;BYMONTHDAY=1;COUNT=1;  // string | An iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as the start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details. (optional) 
            var createChat = 0;  // int? | Should the sending method try to create new Chat(if not exist) with specified recipients? (optional)  (default to 0)
            var tts = 0;  // int? | Send Text-to-Speech message. (optional)  (default to 0)
            var local = 0;  // int? | Treat phone numbers passed in the \\'phones\\' field as local. (optional)  (default to 0)
            var localCountry = US;  // string | The 2-letter ISO country code for local phone numbers, used when \\'local\\' is set to true. Default is the account country. (optional) 

            try
            {
                // Preview message
                GetMessagePreviewResponse result = apiInstance.GetMessagePreview(text, templateId, sendingTime, sendingDateTime, sendingTimezone, contacts, lists, phones, cutExtra, partsCount, referenceId, from, rule, createChat, tts, local, localCountry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessagePreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessagePreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Preview message
    ApiResponse<GetMessagePreviewResponse> response = apiInstance.GetMessagePreviewWithHttpInfo(text, templateId, sendingTime, sendingDateTime, sendingTimezone, contacts, lists, phones, cutExtra, partsCount, referenceId, from, rule, createChat, tts, local, localCountry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessagePreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **text** | **string** | Message text. Required if **template_id** is not set. | [optional]  |
| **templateId** | **int?** | Template used instead of message text. Required if **text** is not set. | [optional]  |
| **sendingTime** | **int?** | DEPRECATED, consider using sendingDateTime and sendingTimezone parameters instead: Optional (required with rrule set). Message sending time is in unix timestamp format. Default is now. | [optional]  |
| **sendingDateTime** | **string** | Sending time is in Y-m-d H:i:s format (e.g. 2016-05-27 13:02:33). This time is relative to the sendingTimezone. | [optional]  |
| **sendingTimezone** | **string** | The ID or ISO-name of the timezone used for sending when the sendingDateTime parameter is set, e.g. if you specify sendingDateTime &#x3D; \\\&quot;2016-05-27 13:02:33\\\&quot; and sendingTimezone &#x3D; \\\&quot;America/Buenos_Aires\\\&quot;, your message will be sent on May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is the account timezone. | [optional]  |
| **contacts** | **string** | Comma-separated array of contact resources id message will be sent to. | [optional]  |
| **lists** | **string** | Comma-separated array of list resources id message will be sent to. | [optional]  |
| **phones** | **string** | Comma-separated array of E.164 phone numbers message will be sent to. | [optional]  |
| **cutExtra** | **int?** | Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead. | [optional] [default to 0] |
| **partsCount** | **int?** | Maximum message parts count (Textmagic allows sending of 1 to 6 message parts). | [optional] [default to 6] |
| **referenceId** | **int?** | Custom message reference id which can be used in your application infrastructure. | [optional]  |
| **from** | **string** | One of the allowed Sender ID (phone number or alphanumeric sender ID). If the specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs). | [optional]  |
| **rule** | **string** | An iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as the start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details. | [optional]  |
| **createChat** | **int?** | Should the sending method try to create new Chat(if not exist) with specified recipients? | [optional] [default to 0] |
| **tts** | **int?** | Send Text-to-Speech message. | [optional] [default to 0] |
| **local** | **int?** | Treat phone numbers passed in the \\&#39;phones\\&#39; field as local. | [optional] [default to 0] |
| **localCountry** | **string** | The 2-letter ISO country code for local phone numbers, used when \\&#39;local\\&#39; is set to true. Default is the account country. | [optional]  |

### Return type

[**GetMessagePreviewResponse**](GetMessagePreviewResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessageprice"></a>
# **GetMessagePrice**
> GetMessagePriceResponse GetMessagePrice (int? includeBlocked = null, string text = null, int? templateId = null, int? sendingTime = null, string sendingDateTime = null, string sendingTimezone = null, string contacts = null, string lists = null, string phones = null, int? cutExtra = null, int? partsCount = null, int? referenceId = null, string from = null, string rule = null, int? createChat = null, int? tts = null, int? local = null, string localCountry = null)

Check message price

Check pricing for a new outbound message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessagePriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var includeBlocked = 0;  // int? | Should we show the pricing for blocked contacts? (optional)  (default to 0)
            var text = Test message test;  // string | Message text. Required if the **template_id** is not set. (optional) 
            var templateId = 1;  // int? | Template used instead of message text. Required if the **text** is not set. (optional) 
            var sendingTime = 1565606455;  // int? | DEPRECATED, consider using the sendingDateTime and sendingTimezone parameters instead: optional (required with rrule set). Message sending time is in unix timestamp format. Default is now. (optional) 
            var sendingDateTime = 2020-05-27 13:02:33;  // string | Sending time is in Y-m-d H:i:s format (e.g. 2016-05-27 13:02:33). This time is relative to the sendingTimezone. (optional) 
            var sendingTimezone = America/Buenos_Aires;  // string | The ID or ISO-name of the timezone used for sending when sendingDateTime parameter is set, e.g. if you specify sendingDateTime = \\\"2016-05-27 13:02:33\\\" and sendingTimezone = \\\"America/Buenos_Aires\\\", your message will be sent on May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is the account timezone. (optional) 
            var contacts = 1,2,3,4;  // string | Comma-separated array of contact resources id message will be sent to. (optional) 
            var lists = 1,2,3,4;  // string | Comma-separated array of list resources id message will be sent to. (optional) 
            var phones = 447860021130,447860021131;  // string | Comma-separated array of E.164 phone numbers message will be sent to. (optional) 
            var cutExtra = 0;  // int? | Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead. (optional)  (default to 0)
            var partsCount = 6;  // int? | Maximum message parts count (Textmagic allows sending 1 to 6 message parts). (optional)  (default to 6)
            var referenceId = 1;  // int? | Custom message reference id which can be used in your application infrastructure. (optional) 
            var from = Test Sender ID;  // string | One of the allowed Sender ID (phone number or alphanumeric sender ID). If the specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs). (optional) 
            var rule = FREQ=YEARLY;BYMONTH=1;BYMONTHDAY=1;COUNT=1;  // string | An iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as the start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details. (optional) 
            var createChat = 0;  // int? | Should the sending method try to create new Chat (if not exist) with specified recipients? (optional)  (default to 0)
            var tts = 0;  // int? | Send a Text-to-Speech message. (optional)  (default to 0)
            var local = 0;  // int? | Treat phone numbers passed in the \\'phones\\' field as local. (optional)  (default to 0)
            var localCountry = US;  // string | The 2-letter ISO country code for local phone numbers, used when \\'local\\' is set to true. Default is the account country. (optional) 

            try
            {
                // Check message price
                GetMessagePriceResponse result = apiInstance.GetMessagePrice(includeBlocked, text, templateId, sendingTime, sendingDateTime, sendingTimezone, contacts, lists, phones, cutExtra, partsCount, referenceId, from, rule, createChat, tts, local, localCountry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessagePrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessagePriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check message price
    ApiResponse<GetMessagePriceResponse> response = apiInstance.GetMessagePriceWithHttpInfo(includeBlocked, text, templateId, sendingTime, sendingDateTime, sendingTimezone, contacts, lists, phones, cutExtra, partsCount, referenceId, from, rule, createChat, tts, local, localCountry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessagePriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeBlocked** | **int?** | Should we show the pricing for blocked contacts? | [optional] [default to 0] |
| **text** | **string** | Message text. Required if the **template_id** is not set. | [optional]  |
| **templateId** | **int?** | Template used instead of message text. Required if the **text** is not set. | [optional]  |
| **sendingTime** | **int?** | DEPRECATED, consider using the sendingDateTime and sendingTimezone parameters instead: optional (required with rrule set). Message sending time is in unix timestamp format. Default is now. | [optional]  |
| **sendingDateTime** | **string** | Sending time is in Y-m-d H:i:s format (e.g. 2016-05-27 13:02:33). This time is relative to the sendingTimezone. | [optional]  |
| **sendingTimezone** | **string** | The ID or ISO-name of the timezone used for sending when sendingDateTime parameter is set, e.g. if you specify sendingDateTime &#x3D; \\\&quot;2016-05-27 13:02:33\\\&quot; and sendingTimezone &#x3D; \\\&quot;America/Buenos_Aires\\\&quot;, your message will be sent on May 27, 2016 13:02:33 Buenos Aires time, or 16:02:33 UTC. Default is the account timezone. | [optional]  |
| **contacts** | **string** | Comma-separated array of contact resources id message will be sent to. | [optional]  |
| **lists** | **string** | Comma-separated array of list resources id message will be sent to. | [optional]  |
| **phones** | **string** | Comma-separated array of E.164 phone numbers message will be sent to. | [optional]  |
| **cutExtra** | **int?** | Should sending method cut extra characters which not fit supplied partsCount or return 400 Bad request response instead. | [optional] [default to 0] |
| **partsCount** | **int?** | Maximum message parts count (Textmagic allows sending 1 to 6 message parts). | [optional] [default to 6] |
| **referenceId** | **int?** | Custom message reference id which can be used in your application infrastructure. | [optional]  |
| **from** | **string** | One of the allowed Sender ID (phone number or alphanumeric sender ID). If the specified Sender ID is not allowed for some destinations, a fallback default Sender ID will be used to ensure delivery. See [Get timezones](https://docs.textmagic.com/#tag/Sender-IDs). | [optional]  |
| **rule** | **string** | An iCal RRULE parameter to create recurrent scheduled messages. When used, sendingTime is mandatory as the start point of sending. See https://www.textmagic.com/free-tools/rrule-generator for format details. | [optional]  |
| **createChat** | **int?** | Should the sending method try to create new Chat (if not exist) with specified recipients? | [optional] [default to 0] |
| **tts** | **int?** | Send a Text-to-Speech message. | [optional] [default to 0] |
| **local** | **int?** | Treat phone numbers passed in the \\&#39;phones\\&#39; field as local. | [optional] [default to 0] |
| **localCountry** | **string** | The 2-letter ISO country code for local phone numbers, used when \\&#39;local\\&#39; is set to true. Default is the account country. | [optional]  |

### Return type

[**GetMessagePriceResponse**](GetMessagePriceResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagesession"></a>
# **GetMessageSession**
> MessageSession GetMessageSession (int id)

Get a session`s details

Get a specific session’s details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessageSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | Session ID.

            try
            {
                // Get a session`s details
                MessageSession result = apiInstance.GetMessageSession(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessageSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a session`s details
    ApiResponse<MessageSession> response = apiInstance.GetMessageSessionWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessageSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Session ID. |  |

### Return type

[**MessageSession**](MessageSession.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagesessionstat"></a>
# **GetMessageSessionStat**
> GetMessageSessionStatResponse GetMessageSessionStat (int id, int? includeDeleted = null)

Get a session`s statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessageSessionStatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var includeDeleted = 0;  // int? | Search also in deleted messages. (optional)  (default to 0)

            try
            {
                // Get a session`s statistics
                GetMessageSessionStatResponse result = apiInstance.GetMessageSessionStat(id, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessageSessionStat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessageSessionStatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a session`s statistics
    ApiResponse<GetMessageSessionStatResponse> response = apiInstance.GetMessageSessionStatWithHttpInfo(id, includeDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessageSessionStatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **includeDeleted** | **int?** | Search also in deleted messages. | [optional] [default to 0] |

### Return type

[**GetMessageSessionStatResponse**](GetMessageSessionStatResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagesbysessionid"></a>
# **GetMessagesBySessionId**
> GetMessagesBySessionIdPaginatedResponse GetMessagesBySessionId (int id, int? page = null, int? limit = null, string statuses = null, int? includeDeleted = null)

Get a session`s messages

A useful synonym for the \"messages/search\" command with the provided \"sessionId\" parameter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessagesBySessionIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var statuses = "q";  // string | Find messages by status. (optional) 
            var includeDeleted = 0;  // int? | Search also in deleted messages. (optional)  (default to 0)

            try
            {
                // Get a session`s messages
                GetMessagesBySessionIdPaginatedResponse result = apiInstance.GetMessagesBySessionId(id, page, limit, statuses, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessagesBySessionId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessagesBySessionIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a session`s messages
    ApiResponse<GetMessagesBySessionIdPaginatedResponse> response = apiInstance.GetMessagesBySessionIdWithHttpInfo(id, page, limit, statuses, includeDeleted);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessagesBySessionIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **statuses** | **string** | Find messages by status. | [optional]  |
| **includeDeleted** | **int?** | Search also in deleted messages. | [optional] [default to 0] |

### Return type

[**GetMessagesBySessionIdPaginatedResponse**](GetMessagesBySessionIdPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagingcounters"></a>
# **GetMessagingCounters**
> GetMessagingCountersResponse GetMessagingCounters ()

Get sent/received messages counters values

Get total contacts, sent messages and received messages counters values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessagingCountersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Get sent/received messages counters values
                GetMessagingCountersResponse result = apiInstance.GetMessagingCounters();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessagingCounters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessagingCountersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get sent/received messages counters values
    ApiResponse<GetMessagingCountersResponse> response = apiInstance.GetMessagingCountersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessagingCountersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetMessagingCountersResponse**](GetMessagingCountersResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmessagingstat"></a>
# **GetMessagingStat**
> List&lt;MessagingStatItem&gt; GetMessagingStat (string by = null, int? start = null, int? end = null)

Get messaging statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetMessagingStatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var by = off;  // string | *   **off** - to get total values per specified time interval; *   **day** - to show values grouped by day; *   **month** - to show values grouped by month; *   **year** - to show values grouped by year.  (optional)  (default to off)
            var start = 1430438400;  // int? | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is 7 days prior.  (optional) 
            var end = 1431648000;  // int? | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is today.  (optional) 

            try
            {
                // Get messaging statistics
                List<MessagingStatItem> result = apiInstance.GetMessagingStat(by, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetMessagingStat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMessagingStatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get messaging statistics
    ApiResponse<List<MessagingStatItem>> response = apiInstance.GetMessagingStatWithHttpInfo(by, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetMessagingStatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **by** | **string** | *   **off** - to get total values per specified time interval; *   **day** - to show values grouped by day; *   **month** - to show values grouped by month; *   **year** - to show values grouped by year.  | [optional] [default to off] |
| **start** | **int?** | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is 7 days prior.  | [optional]  |
| **end** | **int?** | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is today.  | [optional]  |

### Return type

[**List&lt;MessagingStatItem&gt;**](MessagingStatItem.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoutboundmessage"></a>
# **GetOutboundMessage**
> MessageOut GetOutboundMessage (int id)

Get a single message

Get a single outgoing message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetOutboundMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get a single message
                MessageOut result = apiInstance.GetOutboundMessage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetOutboundMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOutboundMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single message
    ApiResponse<MessageOut> response = apiInstance.GetOutboundMessageWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetOutboundMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**MessageOut**](MessageOut.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoutboundmessageshistory"></a>
# **GetOutboundMessagesHistory**
> GetOutboundMessagesHistoryPaginatedResponse GetOutboundMessagesHistory (int? limit = null, int? lastId = null, string query = null, string orderBy = null, string direction = null)

Get history

Get the outbound messages history.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetOutboundMessagesHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var lastId = 56;  // int? | Filter results by ID, selecting all values lesser than the specified ID. (optional) 
            var query = "query_example";  // string | Find message by specified search query. (optional) 
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Get history
                GetOutboundMessagesHistoryPaginatedResponse result = apiInstance.GetOutboundMessagesHistory(limit, lastId, query, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetOutboundMessagesHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOutboundMessagesHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get history
    ApiResponse<GetOutboundMessagesHistoryPaginatedResponse> response = apiInstance.GetOutboundMessagesHistoryWithHttpInfo(limit, lastId, query, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetOutboundMessagesHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **lastId** | **int?** | Filter results by ID, selecting all values lesser than the specified ID. | [optional]  |
| **query** | **string** | Find message by specified search query. | [optional]  |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**GetOutboundMessagesHistoryPaginatedResponse**](GetOutboundMessagesHistoryPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscheduledmessage"></a>
# **GetScheduledMessage**
> MessagesIcs GetScheduledMessage (int id)

Get a single scheduled message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetScheduledMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get a single scheduled message
                MessagesIcs result = apiInstance.GetScheduledMessage(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetScheduledMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduledMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single scheduled message
    ApiResponse<MessagesIcs> response = apiInstance.GetScheduledMessageWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetScheduledMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**MessagesIcs**](MessagesIcs.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsenderid"></a>
# **GetSenderId**
> SenderId GetSenderId (int id)

Get the details of a specific Sender ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetSenderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get the details of a specific Sender ID
                SenderId result = apiInstance.GetSenderId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetSenderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSenderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific Sender ID
    ApiResponse<SenderId> response = apiInstance.GetSenderIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetSenderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**SenderId**](SenderId.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender ID data returned with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsenderids"></a>
# **GetSenderIds**
> GetSenderIdsPaginatedResponse GetSenderIds (int? page = null, int? limit = null)

Get all your approved Sender IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetSenderIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get all your approved Sender IDs
                GetSenderIdsPaginatedResponse result = apiInstance.GetSenderIds(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetSenderIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSenderIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all your approved Sender IDs
    ApiResponse<GetSenderIdsPaginatedResponse> response = apiInstance.GetSenderIdsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetSenderIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetSenderIdsPaginatedResponse**](GetSenderIdsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender IDs of the current user returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsendersettings"></a>
# **GetSenderSettings**
> GetSenderSettingsResponse GetSenderSettings (string country = null)

Get current sender settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetSenderSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var country = US;  // string | Return sender settings enabled for sending to a specified country. Should be 2 upper-case characters. (optional) 

            try
            {
                // Get current sender settings
                GetSenderSettingsResponse result = apiInstance.GetSenderSettings(country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetSenderSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSenderSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get current sender settings
    ApiResponse<GetSenderSettingsResponse> response = apiInstance.GetSenderSettingsWithHttpInfo(country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetSenderSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | Return sender settings enabled for sending to a specified country. Should be 2 upper-case characters. | [optional]  |

### Return type

[**GetSenderSettingsResponse**](GetSenderSettingsResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sender settings returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getspendingstat"></a>
# **GetSpendingStat**
> GetSpendingStatPaginatedResponse GetSpendingStat (int? page = null, int? limit = null, string start = null, string end = null)

Get spending statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetSpendingStatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var start = 2018-11-11 11:11;  // string | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is 7 days prior.  (optional) 
            var end = 2019-11-11 11:11;  // string | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is today.  (optional) 

            try
            {
                // Get spending statistics
                GetSpendingStatPaginatedResponse result = apiInstance.GetSpendingStat(page, limit, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetSpendingStat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSpendingStatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get spending statistics
    ApiResponse<GetSpendingStatPaginatedResponse> response = apiInstance.GetSpendingStatWithHttpInfo(page, limit, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetSpendingStatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **start** | **string** | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is 7 days prior.  | [optional]  |
| **end** | **string** | Time period start in [UNIX timestamp](https://en.wikipedia.org/wiki/Unix_time) format. The default is today.  | [optional]  |

### Return type

[**GetSpendingStatPaginatedResponse**](GetSpendingStatPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettemplate"></a>
# **GetTemplate**
> MessageTemplate GetTemplate (int id)

Get a template`s details

Get a single template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get a template`s details
                MessageTemplate result = apiInstance.GetTemplate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a template`s details
    ApiResponse<MessageTemplate> response = apiInstance.GetTemplateWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**MessageTemplate**](MessageTemplate.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettimezones"></a>
# **GetTimezones**
> Object GetTimezones (int? full = null)

Get timezones

Return all available timezone IDs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetTimezonesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var full = 0;  // int? | Return full info about timezones in array (0 or 1). Default is 0. (optional)  (default to 0)

            try
            {
                // Get timezones
                Object result = apiInstance.GetTimezones(full);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetTimezones: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTimezonesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get timezones
    ApiResponse<Object> response = apiInstance.GetTimezonesWithHttpInfo(full);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetTimezonesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **full** | **int?** | Return full info about timezones in array (0 or 1). Default is 0. | [optional] [default to 0] |

### Return type

**Object**

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getunreadmessagestotal"></a>
# **GetUnreadMessagesTotal**
> GetUnreadMessagesTotalResponse GetUnreadMessagesTotal ()

Get unread messages number

Get the total amount of unread messages in the current user chats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetUnreadMessagesTotalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Get unread messages number
                GetUnreadMessagesTotalResponse result = apiInstance.GetUnreadMessagesTotal();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetUnreadMessagesTotal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUnreadMessagesTotalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get unread messages number
    ApiResponse<GetUnreadMessagesTotalResponse> response = apiInstance.GetUnreadMessagesTotalWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetUnreadMessagesTotalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetUnreadMessagesTotalResponse**](GetUnreadMessagesTotalResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getunsubscribedcontact"></a>
# **GetUnsubscribedContact**
> UnsubscribedContact GetUnsubscribedContact (int id)

Get the details of a specific unsubscribed contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetUnsubscribedContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 

            try
            {
                // Get the details of a specific unsubscribed contact
                UnsubscribedContact result = apiInstance.GetUnsubscribedContact(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetUnsubscribedContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUnsubscribedContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the details of a specific unsubscribed contact
    ApiResponse<UnsubscribedContact> response = apiInstance.GetUnsubscribedContactWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetUnsubscribedContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**UnsubscribedContact**](UnsubscribedContact.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getunsubscribers"></a>
# **GetUnsubscribers**
> GetUnsubscribersPaginatedResponse GetUnsubscribers (int? page = null, int? limit = null)

Get all unsubscribed contacts

When one of your message recipients sends a request with one of the [STOP-words](https://www.textmagic.com/sms-stop-command/), they will be immediately opted-out of your send lists and their contact status will change to an unsubscribed contact. To retrieve information on all contacts who have unsubscribed status, use: 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetUnsubscribersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)

            try
            {
                // Get all unsubscribed contacts
                GetUnsubscribersPaginatedResponse result = apiInstance.GetUnsubscribers(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetUnsubscribers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUnsubscribersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all unsubscribed contacts
    ApiResponse<GetUnsubscribersPaginatedResponse> response = apiInstance.GetUnsubscribersWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetUnsubscribersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |

### Return type

[**GetUnsubscribersPaginatedResponse**](GetUnsubscribersPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserdedicatednumbers"></a>
# **GetUserDedicatedNumbers**
> GetUserDedicatedNumbersPaginatedResponse GetUserDedicatedNumbers (int? page = null, int? limit = null, int? surveyId = null)

Get all your dedicated numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class GetUserDedicatedNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var surveyId = 56;  // int? | Fetch only those numbers that are ready for the survey. (optional) 

            try
            {
                // Get all your dedicated numbers
                GetUserDedicatedNumbersPaginatedResponse result = apiInstance.GetUserDedicatedNumbers(page, limit, surveyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.GetUserDedicatedNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserDedicatedNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all your dedicated numbers
    ApiResponse<GetUserDedicatedNumbersPaginatedResponse> response = apiInstance.GetUserDedicatedNumbersWithHttpInfo(page, limit, surveyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.GetUserDedicatedNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **surveyId** | **int?** | Fetch only those numbers that are ready for the survey. | [optional]  |

### Return type

[**GetUserDedicatedNumbersPaginatedResponse**](GetUserDedicatedNumbersPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Requested data returned with success. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="importcontacts"></a>
# **ImportContacts**
> ResourceLinkResponse ImportContacts (string column, System.IO.Stream file, int? listId = null, string listName = null)

Import contacts

Import contacts from the CSV, XLS or XLSX file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class ImportContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var column = 0:firstName;1:lastName;3:phone;4:email;  // string | Import file column mapping. The string must contain sub-strings of mapping in format `columnNumber:field` glued by `;`. For example: `0:firstName;1:lastName;3:phone;4:email` where the value before `:` is a number of the column in the file, and the value after `:` is a field of the newly created contact or the ID of a custom field. Numbers of columns begin from zero. Allowed built-in contact fields are: `firstName`, `lastName`, `phone`, `email`. Existing of `phone` mapping is required. 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File containing contacts in csv or xls(x) formats.
            var listId = 443;  // int? | List that ID contacts will be imported to. Ignored if `listName` is specified.  (optional) 
            var listName = A new list;  // string | List name. This list will be created during import. If such name is already taken, an ordinal (1, 2, ...) will be added to the end. Ignored if `listId` is specified.  (optional) 

            try
            {
                // Import contacts
                ResourceLinkResponse result = apiInstance.ImportContacts(column, file, listId, listName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.ImportContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import contacts
    ApiResponse<ResourceLinkResponse> response = apiInstance.ImportContactsWithHttpInfo(column, file, listId, listName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.ImportContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **column** | **string** | Import file column mapping. The string must contain sub-strings of mapping in format &#x60;columnNumber:field&#x60; glued by &#x60;;&#x60;. For example: &#x60;0:firstName;1:lastName;3:phone;4:email&#x60; where the value before &#x60;:&#x60; is a number of the column in the file, and the value after &#x60;:&#x60; is a field of the newly created contact or the ID of a custom field. Numbers of columns begin from zero. Allowed built-in contact fields are: &#x60;firstName&#x60;, &#x60;lastName&#x60;, &#x60;phone&#x60;, &#x60;email&#x60;. Existing of &#x60;phone&#x60; mapping is required.  |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File containing contacts in csv or xls(x) formats. |  |
| **listId** | **int?** | List that ID contacts will be imported to. Ignored if &#x60;listName&#x60; is specified.  | [optional]  |
| **listName** | **string** | List name. This list will be created during import. If such name is already taken, an ordinal (1, 2, ...) will be added to the end. Ignored if &#x60;listId&#x60; is specified.  | [optional]  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="markchatsreadbulk"></a>
# **MarkChatsReadBulk**
> void MarkChatsReadBulk (MarkChatsUnreadBulkRequest markChatsReadBulkInputObject)

Mark chats as read (bulk)

Mark several chats as read by chat IDs or mark all chats as read

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class MarkChatsReadBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var markChatsReadBulkInputObject = new MarkChatsUnreadBulkRequest(); // MarkChatsUnreadBulkRequest | 

            try
            {
                // Mark chats as read (bulk)
                apiInstance.MarkChatsReadBulk(markChatsReadBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.MarkChatsReadBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkChatsReadBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark chats as read (bulk)
    apiInstance.MarkChatsReadBulkWithHttpInfo(markChatsReadBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.MarkChatsReadBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **markChatsReadBulkInputObject** | [**MarkChatsUnreadBulkRequest**](MarkChatsUnreadBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="markchatsunreadbulk"></a>
# **MarkChatsUnreadBulk**
> void MarkChatsUnreadBulk (MarkChatsUnreadBulkRequest markChatsUnreadBulkInputObject)

Mark chats as unread (bulk)

Mark several chats as UNread by chat IDs or mark all chats as UNread

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class MarkChatsUnreadBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var markChatsUnreadBulkInputObject = new MarkChatsUnreadBulkRequest(); // MarkChatsUnreadBulkRequest | 

            try
            {
                // Mark chats as unread (bulk)
                apiInstance.MarkChatsUnreadBulk(markChatsUnreadBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.MarkChatsUnreadBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkChatsUnreadBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mark chats as unread (bulk)
    apiInstance.MarkChatsUnreadBulkWithHttpInfo(markChatsUnreadBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.MarkChatsUnreadBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **markChatsUnreadBulkInputObject** | [**MarkChatsUnreadBulkRequest**](MarkChatsUnreadBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mutechat"></a>
# **MuteChat**
> ResourceLinkResponse MuteChat (MuteChatRequest muteChatInputObject)

Mute chat sounds

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class MuteChatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var muteChatInputObject = new MuteChatRequest(); // MuteChatRequest | 

            try
            {
                // Mute chat sounds
                ResourceLinkResponse result = apiInstance.MuteChat(muteChatInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.MuteChat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MuteChatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mute chat sounds
    ApiResponse<ResourceLinkResponse> response = apiInstance.MuteChatWithHttpInfo(muteChatInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.MuteChatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **muteChatInputObject** | [**MuteChatRequest**](MuteChatRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mutechatsbulk"></a>
# **MuteChatsBulk**
> void MuteChatsBulk (MuteChatsBulkRequest muteChatsBulkInputObject)

Mute chats (bulk)

Mute several chats by chat ids or mute all chats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class MuteChatsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var muteChatsBulkInputObject = new MuteChatsBulkRequest(); // MuteChatsBulkRequest | 

            try
            {
                // Mute chats (bulk)
                apiInstance.MuteChatsBulk(muteChatsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.MuteChatsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MuteChatsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mute chats (bulk)
    apiInstance.MuteChatsBulkWithHttpInfo(muteChatsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.MuteChatsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **muteChatsBulkInputObject** | [**MuteChatsBulkRequest**](MuteChatsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ping"></a>
# **Ping**
> PingResponse Ping ()

Ping

Make a simple ping request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class PingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);

            try
            {
                // Ping
                PingResponse result = apiInstance.Ping();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.Ping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Ping
    ApiResponse<PingResponse> response = apiInstance.PingWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.PingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PingResponse**](PingResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reopenchatsbulk"></a>
# **ReopenChatsBulk**
> void ReopenChatsBulk (MarkChatsUnreadBulkRequest reopenChatsBulkInputObject)

Reopen chats (bulk)

Reopen chats by chat IDs or reopen all chats

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class ReopenChatsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var reopenChatsBulkInputObject = new MarkChatsUnreadBulkRequest(); // MarkChatsUnreadBulkRequest | 

            try
            {
                // Reopen chats (bulk)
                apiInstance.ReopenChatsBulk(reopenChatsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.ReopenChatsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReopenChatsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reopen chats (bulk)
    apiInstance.ReopenChatsBulkWithHttpInfo(reopenChatsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.ReopenChatsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **reopenChatsBulkInputObject** | [**MarkChatsUnreadBulkRequest**](MarkChatsUnreadBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requestsenderid"></a>
# **RequestSenderId**
> ResourceLinkResponse RequestSenderId (RequestSenderIdRequest requestSenderIdInputObject)

Apply for a new Sender ID

> Sender IDs are shared among all of your sub-accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class RequestSenderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var requestSenderIdInputObject = new RequestSenderIdRequest(); // RequestSenderIdRequest | 

            try
            {
                // Apply for a new Sender ID
                ResourceLinkResponse result = apiInstance.RequestSenderId(requestSenderIdInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.RequestSenderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestSenderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply for a new Sender ID
    ApiResponse<ResourceLinkResponse> response = apiInstance.RequestSenderIdWithHttpInfo(requestSenderIdInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.RequestSenderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestSenderIdInputObject** | [**RequestSenderIdRequest**](RequestSenderIdRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Sender ID request has been created with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="scheduleemailcampaign"></a>
# **ScheduleEmailCampaign**
> ScheduleEmailCampaignResponse ScheduleEmailCampaign (ScheduleEmailCampaignRequest scheduleEmailCampaignInputObject)

Schedule new email campaign

Creates a new scheduled email campaign that will be sent at a specified time or according to a recurring schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class ScheduleEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var scheduleEmailCampaignInputObject = new ScheduleEmailCampaignRequest(); // ScheduleEmailCampaignRequest | 

            try
            {
                // Schedule new email campaign
                ScheduleEmailCampaignResponse result = apiInstance.ScheduleEmailCampaign(scheduleEmailCampaignInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.ScheduleEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduleEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedule new email campaign
    ApiResponse<ScheduleEmailCampaignResponse> response = apiInstance.ScheduleEmailCampaignWithHttpInfo(scheduleEmailCampaignInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.ScheduleEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scheduleEmailCampaignInputObject** | [**ScheduleEmailCampaignRequest**](ScheduleEmailCampaignRequest.md) |  |  |

### Return type

[**ScheduleEmailCampaignResponse**](ScheduleEmailCampaignResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Email campaign scheduled successfully. |  -  |
| **400** | Bad request - validation errors, invalid schedule, or insufficient balance. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Forbidden - insufficient permissions (requires ComposeEmail access). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchchats"></a>
# **SearchChats**
> SearchChatsPaginatedResponse SearchChats (int? page = null, int? limit = null, string query = null)

Find chats by message text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchChatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var query = "query_example";  // string | Find chats by specified search query. (optional) 

            try
            {
                // Find chats by message text
                SearchChatsPaginatedResponse result = apiInstance.SearchChats(page, limit, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchChats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchChatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find chats by message text
    ApiResponse<SearchChatsPaginatedResponse> response = apiInstance.SearchChatsWithHttpInfo(page, limit, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchChatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **query** | **string** | Find chats by specified search query. | [optional]  |

### Return type

[**SearchChatsPaginatedResponse**](SearchChatsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchchatsbyids"></a>
# **SearchChatsByIds**
> SearchChatsByIdsPaginatedResponse SearchChatsByIds (int? page = null, int? limit = null, string ids = null)

Find chats (bulk)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchChatsByIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var ids = "ids_example";  // string | Find chats by ID(s). (optional) 

            try
            {
                // Find chats (bulk)
                SearchChatsByIdsPaginatedResponse result = apiInstance.SearchChatsByIds(page, limit, ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchChatsByIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchChatsByIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find chats (bulk)
    ApiResponse<SearchChatsByIdsPaginatedResponse> response = apiInstance.SearchChatsByIdsWithHttpInfo(page, limit, ids);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchChatsByIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **ids** | **string** | Find chats by ID(s). | [optional]  |

### Return type

[**SearchChatsByIdsPaginatedResponse**](SearchChatsByIdsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchchatsbyreceipent"></a>
# **SearchChatsByReceipent**
> SearchChatsByReceipentPaginatedResponse SearchChatsByReceipent (int? page = null, int? limit = null, string query = null, string orderBy = null)

Find chats by recipient

Find chats by recipient (contact, list name or phone number).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchChatsByReceipentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var query = "query_example";  // string | Find chats by specified search query. (optional) 
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)

            try
            {
                // Find chats by recipient
                SearchChatsByReceipentPaginatedResponse result = apiInstance.SearchChatsByReceipent(page, limit, query, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchChatsByReceipent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchChatsByReceipentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find chats by recipient
    ApiResponse<SearchChatsByReceipentPaginatedResponse> response = apiInstance.SearchChatsByReceipentWithHttpInfo(page, limit, query, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchChatsByReceipentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **query** | **string** | Find chats by specified search query. | [optional]  |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |

### Return type

[**SearchChatsByReceipentPaginatedResponse**](SearchChatsByReceipentPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchcontacts"></a>
# **SearchContacts**
> SearchContactsPaginatedResponse SearchContacts (int? page = null, int? limit = null, int? shared = null, string ids = null, int? listId = null, int? includeBlocked = null, string query = null, int? local = null, int? exactMatch = null, string country = null, string orderBy = null, string direction = null, string tagIds = null)

Find contacts by given criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var shared = 0;  // int? | Should shared contacts be included? (optional)  (default to 0)
            var ids = "ids_example";  // string | Find contacts by IDs. (optional) 
            var listId = 56;  // int? | Find contacts by List ID. (optional) 
            var includeBlocked = 0;  // int? | Should blocked contacts be included? (optional) 
            var query = "query_example";  // string | Find contacts by specified search query. (optional) 
            var local = 0;  // int? | Treat phone number passed in the \"query\" field as local. Default is 0. (optional)  (default to 0)
            var exactMatch = 0;  // int? | Return only exactly matching contacts. Default is 0. (optional)  (default to 0)
            var country = "country_example";  // string | The 2-letter ISO country code for local phone numbers, used when \"local\" is set to true. Default is the account country. (optional) 
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)
            var tagIds = "tagIds_example";  // string | Find contacts by tag ID(s). Multiple IDs can be separated by comma. (optional) 

            try
            {
                // Find contacts by given criteria
                SearchContactsPaginatedResponse result = apiInstance.SearchContacts(page, limit, shared, ids, listId, includeBlocked, query, local, exactMatch, country, orderBy, direction, tagIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find contacts by given criteria
    ApiResponse<SearchContactsPaginatedResponse> response = apiInstance.SearchContactsWithHttpInfo(page, limit, shared, ids, listId, includeBlocked, query, local, exactMatch, country, orderBy, direction, tagIds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **shared** | **int?** | Should shared contacts be included? | [optional] [default to 0] |
| **ids** | **string** | Find contacts by IDs. | [optional]  |
| **listId** | **int?** | Find contacts by List ID. | [optional]  |
| **includeBlocked** | **int?** | Should blocked contacts be included? | [optional]  |
| **query** | **string** | Find contacts by specified search query. | [optional]  |
| **local** | **int?** | Treat phone number passed in the \&quot;query\&quot; field as local. Default is 0. | [optional] [default to 0] |
| **exactMatch** | **int?** | Return only exactly matching contacts. Default is 0. | [optional] [default to 0] |
| **country** | **string** | The 2-letter ISO country code for local phone numbers, used when \&quot;local\&quot; is set to true. Default is the account country. | [optional]  |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |
| **tagIds** | **string** | Find contacts by tag ID(s). Multiple IDs can be separated by comma. | [optional]  |

### Return type

[**SearchContactsPaginatedResponse**](SearchContactsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Found contacts have been returned with success. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchinboundmessages"></a>
# **SearchInboundMessages**
> SearchInboundMessagesPaginatedResponse SearchInboundMessages (int? page = null, int? limit = null, string ids = null, string query = null, string orderBy = null, string direction = null, int? expand = null)

Find inbound messages

Find inbound messages by given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchInboundMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var ids = "ids_example";  // string | Find message by ID(s). (optional) 
            var query = "query_example";  // string | Find recipients by specified search query. (optional) 
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)
            var expand = 0;  // int? | Expand by adding firstName, lastName and contactId. (optional)  (default to 0)

            try
            {
                // Find inbound messages
                SearchInboundMessagesPaginatedResponse result = apiInstance.SearchInboundMessages(page, limit, ids, query, orderBy, direction, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchInboundMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchInboundMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find inbound messages
    ApiResponse<SearchInboundMessagesPaginatedResponse> response = apiInstance.SearchInboundMessagesWithHttpInfo(page, limit, ids, query, orderBy, direction, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchInboundMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **ids** | **string** | Find message by ID(s). | [optional]  |
| **query** | **string** | Find recipients by specified search query. | [optional]  |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |
| **expand** | **int?** | Expand by adding firstName, lastName and contactId. | [optional] [default to 0] |

### Return type

[**SearchInboundMessagesPaginatedResponse**](SearchInboundMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchlists"></a>
# **SearchLists**
> SearchListsPaginatedResponse SearchLists (int? page = null, int? limit = null, string ids = null, string query = null, int? onlyMine = null, int? onlyDefault = null, string orderBy = null, string direction = null)

Find lists by given criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var ids = 1,2,3,4;  // string | Find lists by IDs. (optional) 
            var query = A;  // string | Find lists by specified search query. (optional) 
            var onlyMine = 0;  // int? | Return only current user lists. (optional)  (default to 0)
            var onlyDefault = 0;  // int? | Return only default lists. (optional)  (default to 0)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Find lists by given criteria
                SearchListsPaginatedResponse result = apiInstance.SearchLists(page, limit, ids, query, onlyMine, onlyDefault, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find lists by given criteria
    ApiResponse<SearchListsPaginatedResponse> response = apiInstance.SearchListsWithHttpInfo(page, limit, ids, query, onlyMine, onlyDefault, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **ids** | **string** | Find lists by IDs. | [optional]  |
| **query** | **string** | Find lists by specified search query. | [optional]  |
| **onlyMine** | **int?** | Return only current user lists. | [optional] [default to 0] |
| **onlyDefault** | **int?** | Return only default lists. | [optional] [default to 0] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**SearchListsPaginatedResponse**](SearchListsPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchoutboundmessages"></a>
# **SearchOutboundMessages**
> SearchOutboundMessagesPaginatedResponse SearchOutboundMessages (int? page = null, int? limit = null, int? lastId = null, string ids = null, int? sessionId = null, string statuses = null, int? includeDeleted = null, string query = null)

Find messages

Find outbound messages by given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchOutboundMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var lastId = 56;  // int? | Filter results by ID, selecting all values lesser than the specified ID. Note that the \\'page\\' parameter is ignored when \\'lastId\\' is specified. (optional) 
            var ids = "ids_example";  // string | Find message by ID(s). (optional) 
            var sessionId = 56;  // int? | Find messages by session ID. (optional) 
            var statuses = q;  // string | Find messages by status. (optional) 
            var includeDeleted = 0;  // int? | Search also in deleted messages. (optional)  (default to 0)
            var query = "query_example";  // string | Find messages by specified search query. (optional) 

            try
            {
                // Find messages
                SearchOutboundMessagesPaginatedResponse result = apiInstance.SearchOutboundMessages(page, limit, lastId, ids, sessionId, statuses, includeDeleted, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchOutboundMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchOutboundMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find messages
    ApiResponse<SearchOutboundMessagesPaginatedResponse> response = apiInstance.SearchOutboundMessagesWithHttpInfo(page, limit, lastId, ids, sessionId, statuses, includeDeleted, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchOutboundMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **lastId** | **int?** | Filter results by ID, selecting all values lesser than the specified ID. Note that the \\&#39;page\\&#39; parameter is ignored when \\&#39;lastId\\&#39; is specified. | [optional]  |
| **ids** | **string** | Find message by ID(s). | [optional]  |
| **sessionId** | **int?** | Find messages by session ID. | [optional]  |
| **statuses** | **string** | Find messages by status. | [optional]  |
| **includeDeleted** | **int?** | Search also in deleted messages. | [optional] [default to 0] |
| **query** | **string** | Find messages by specified search query. | [optional]  |

### Return type

[**SearchOutboundMessagesPaginatedResponse**](SearchOutboundMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchscheduledmessages"></a>
# **SearchScheduledMessages**
> SearchScheduledMessagesPaginatedResponse SearchScheduledMessages (int? page = null, int? limit = null, string query = null, string ids = null, string status = null, string orderBy = null, string direction = null)

Find scheduled messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchScheduledMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var query = "query_example";  // string | Find messages by specified search query. (optional) 
            var ids = "ids_example";  // string | Find schedules by ID(s). (optional) 
            var status = "x";  // string | Fetch schedules with a specific status: a - actual, c - completed, x - all. (optional)  (default to x)
            var orderBy = "id";  // string | Order results by some field. Default is id. (optional)  (default to id)
            var direction = "asc";  // string | Order direction. Default is desc. (optional)  (default to desc)

            try
            {
                // Find scheduled messages
                SearchScheduledMessagesPaginatedResponse result = apiInstance.SearchScheduledMessages(page, limit, query, ids, status, orderBy, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchScheduledMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchScheduledMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find scheduled messages
    ApiResponse<SearchScheduledMessagesPaginatedResponse> response = apiInstance.SearchScheduledMessagesWithHttpInfo(page, limit, query, ids, status, orderBy, direction);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchScheduledMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **query** | **string** | Find messages by specified search query. | [optional]  |
| **ids** | **string** | Find schedules by ID(s). | [optional]  |
| **status** | **string** | Fetch schedules with a specific status: a - actual, c - completed, x - all. | [optional] [default to x] |
| **orderBy** | **string** | Order results by some field. Default is id. | [optional] [default to id] |
| **direction** | **string** | Order direction. Default is desc. | [optional] [default to desc] |

### Return type

[**SearchScheduledMessagesPaginatedResponse**](SearchScheduledMessagesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchtemplates"></a>
# **SearchTemplates**
> SearchTemplatesPaginatedResponse SearchTemplates (int? page = null, int? limit = null, string ids = null, string name = null, string content = null)

Find templates by criteria

Find user templates by given parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SearchTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var page = 1;  // int? | Fetch specified results page. (optional)  (default to 1)
            var limit = 10;  // int? | The number of results per page. (optional)  (default to 10)
            var ids = "ids_example";  // string | Find template by ID(s). (optional) 
            var name = "name_example";  // string | Find template by name. (optional) 
            var content = "content_example";  // string | Find template by content. (optional) 

            try
            {
                // Find templates by criteria
                SearchTemplatesPaginatedResponse result = apiInstance.SearchTemplates(page, limit, ids, name, content);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SearchTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find templates by criteria
    ApiResponse<SearchTemplatesPaginatedResponse> response = apiInstance.SearchTemplatesWithHttpInfo(page, limit, ids, name, content);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SearchTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Fetch specified results page. | [optional] [default to 1] |
| **limit** | **int?** | The number of results per page. | [optional] [default to 10] |
| **ids** | **string** | Find template by ID(s). | [optional]  |
| **name** | **string** | Find template by name. | [optional]  |
| **content** | **string** | Find template by content. | [optional]  |

### Return type

[**SearchTemplatesPaginatedResponse**](SearchTemplatesPaginatedResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returned when successful. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendmessage"></a>
# **SendMessage**
> SendMessageResponse SendMessage (SendMessageRequest sendMessageInputObject)

Send message

This is the main entrypoint to send messages. See the examples above for the reference.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SendMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var sendMessageInputObject = new SendMessageRequest(); // SendMessageRequest | 

            try
            {
                // Send message
                SendMessageResponse result = apiInstance.SendMessage(sendMessageInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SendMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send message
    ApiResponse<SendMessageResponse> response = apiInstance.SendMessageWithHttpInfo(sendMessageInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SendMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendMessageInputObject** | [**SendMessageRequest**](SendMessageRequest.md) |  |  |

### Return type

[**SendMessageResponse**](SendMessageResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **202** | Returned when a bulk session has been created. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setchatstatus"></a>
# **SetChatStatus**
> ResourceLinkResponse SetChatStatus (SetChatStatusRequest setChatStatusInputObject)

Change chat status

Set the status of the chat given by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class SetChatStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var setChatStatusInputObject = new SetChatStatusRequest(); // SetChatStatusRequest | 

            try
            {
                // Change chat status
                ResourceLinkResponse result = apiInstance.SetChatStatus(setChatStatusInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.SetChatStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetChatStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change chat status
    ApiResponse<ResourceLinkResponse> response = apiInstance.SetChatStatusWithHttpInfo(setChatStatusInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.SetChatStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setChatStatusInputObject** | [**SetChatStatusRequest**](SetChatStatusRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unblockcontact"></a>
# **UnblockContact**
> void UnblockContact (BlockContactRequest unblockContactInputObject)

Unblock a contact by phone number

Unblock a contact by phone number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UnblockContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var unblockContactInputObject = new BlockContactRequest(); // BlockContactRequest | 

            try
            {
                // Unblock a contact by phone number
                apiInstance.UnblockContact(unblockContactInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UnblockContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnblockContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unblock a contact by phone number
    apiInstance.UnblockContactWithHttpInfo(unblockContactInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UnblockContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unblockContactInputObject** | [**BlockContactRequest**](BlockContactRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unblockcontactsbulk"></a>
# **UnblockContactsBulk**
> void UnblockContactsBulk (UnblockContactsBulkRequest unblockContactsBulkInputObject)

Unblock contacts (bulk)

Unblock several contacts by blocked contact IDs or unblock all contacts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UnblockContactsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var unblockContactsBulkInputObject = new UnblockContactsBulkRequest(); // UnblockContactsBulkRequest | 

            try
            {
                // Unblock contacts (bulk)
                apiInstance.UnblockContactsBulk(unblockContactsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UnblockContactsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnblockContactsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unblock contacts (bulk)
    apiInstance.UnblockContactsBulkWithHttpInfo(unblockContactsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UnblockContactsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unblockContactsBulkInputObject** | [**UnblockContactsBulkRequest**](UnblockContactsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unmutechatsbulk"></a>
# **UnmuteChatsBulk**
> void UnmuteChatsBulk (UnmuteChatsBulkRequest unmuteChatsBulkInputObject)

Unmute chats (bulk)

Unmute several chats by chat ids or unmute all chats.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UnmuteChatsBulkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var unmuteChatsBulkInputObject = new UnmuteChatsBulkRequest(); // UnmuteChatsBulkRequest | 

            try
            {
                // Unmute chats (bulk)
                apiInstance.UnmuteChatsBulk(unmuteChatsBulkInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UnmuteChatsBulk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnmuteChatsBulkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unmute chats (bulk)
    apiInstance.UnmuteChatsBulkWithHttpInfo(unmuteChatsBulkInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UnmuteChatsBulkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unmuteChatsBulkInputObject** | [**UnmuteChatsBulkRequest**](UnmuteChatsBulkRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unsubscribecontact"></a>
# **UnsubscribeContact**
> ResourceLinkResponse UnsubscribeContact (UnsubscribeContactRequest unsubscribeContactInputObject)

Manually unsubscribe a contact

> Please note, if you unsubscribe a contact, this action cannot be reversed. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UnsubscribeContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var unsubscribeContactInputObject = new UnsubscribeContactRequest(); // UnsubscribeContactRequest | 

            try
            {
                // Manually unsubscribe a contact
                ResourceLinkResponse result = apiInstance.UnsubscribeContact(unsubscribeContactInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UnsubscribeContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnsubscribeContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manually unsubscribe a contact
    ApiResponse<ResourceLinkResponse> response = apiInstance.UnsubscribeContactWithHttpInfo(unsubscribeContactInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UnsubscribeContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **unsubscribeContactInputObject** | [**UnsubscribeContactRequest**](UnsubscribeContactRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when updated with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatebalancenotificationsettings"></a>
# **UpdateBalanceNotificationSettings**
> void UpdateBalanceNotificationSettings (UpdateBalanceNotificationSettingsRequest updateBalanceNotificationSettingsInputObject)

Update balance notification settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateBalanceNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var updateBalanceNotificationSettingsInputObject = new UpdateBalanceNotificationSettingsRequest(); // UpdateBalanceNotificationSettingsRequest | 

            try
            {
                // Update balance notification settings
                apiInstance.UpdateBalanceNotificationSettings(updateBalanceNotificationSettingsInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateBalanceNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateBalanceNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update balance notification settings
    apiInstance.UpdateBalanceNotificationSettingsWithHttpInfo(updateBalanceNotificationSettingsInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateBalanceNotificationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateBalanceNotificationSettingsInputObject** | [**UpdateBalanceNotificationSettingsRequest**](UpdateBalanceNotificationSettingsRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecallbacksettings"></a>
# **UpdateCallbackSettings**
> void UpdateCallbackSettings (UpdateCallbackSettingsRequest updateCallbackSettingsInputObject)

Update callback URL settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateCallbackSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var updateCallbackSettingsInputObject = new UpdateCallbackSettingsRequest(); // UpdateCallbackSettingsRequest | 

            try
            {
                // Update callback URL settings
                apiInstance.UpdateCallbackSettings(updateCallbackSettingsInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateCallbackSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCallbackSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update callback URL settings
    apiInstance.UpdateCallbackSettingsWithHttpInfo(updateCallbackSettingsInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateCallbackSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateCallbackSettingsInputObject** | [**UpdateCallbackSettingsRequest**](UpdateCallbackSettingsRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatechatdesktopnotificationsettings"></a>
# **UpdateChatDesktopNotificationSettings**
> void UpdateChatDesktopNotificationSettings (UpdateChatDesktopNotificationSettingsRequest updateChatDesktopNotificationSettingsInputObject)

Update chat desktop notification settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateChatDesktopNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var updateChatDesktopNotificationSettingsInputObject = new UpdateChatDesktopNotificationSettingsRequest(); // UpdateChatDesktopNotificationSettingsRequest | 

            try
            {
                // Update chat desktop notification settings
                apiInstance.UpdateChatDesktopNotificationSettings(updateChatDesktopNotificationSettingsInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateChatDesktopNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChatDesktopNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update chat desktop notification settings
    apiInstance.UpdateChatDesktopNotificationSettingsWithHttpInfo(updateChatDesktopNotificationSettingsInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateChatDesktopNotificationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateChatDesktopNotificationSettingsInputObject** | [**UpdateChatDesktopNotificationSettingsRequest**](UpdateChatDesktopNotificationSettingsRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontact"></a>
# **UpdateContact**
> ResourceLinkResponse UpdateContact (int id, UpdateContactRequest updateContactInputObject)

Edit a contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var updateContactInputObject = new UpdateContactRequest(); // UpdateContactRequest | 

            try
            {
                // Edit a contact
                ResourceLinkResponse result = apiInstance.UpdateContact(id, updateContactInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a contact
    ApiResponse<ResourceLinkResponse> response = apiInstance.UpdateContactWithHttpInfo(id, updateContactInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **updateContactInputObject** | [**UpdateContactRequest**](UpdateContactRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The contact has been created with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecontactnote"></a>
# **UpdateContactNote**
> ResourceLinkResponse UpdateContactNote (int id, UpdateContactNoteRequest updateContactNoteInputObject)

Update a contact note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateContactNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var updateContactNoteInputObject = new UpdateContactNoteRequest(); // UpdateContactNoteRequest | 

            try
            {
                // Update a contact note
                ResourceLinkResponse result = apiInstance.UpdateContactNote(id, updateContactNoteInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateContactNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateContactNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a contact note
    ApiResponse<ResourceLinkResponse> response = apiInstance.UpdateContactNoteWithHttpInfo(id, updateContactNoteInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateContactNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **updateContactNoteInputObject** | [**UpdateContactNoteRequest**](UpdateContactNoteRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a contact note shared to a current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecurrentuser"></a>
# **UpdateCurrentUser**
> UpdateCurrentUserResponse UpdateCurrentUser (UpdateCurrentUserRequest updateCurrentUserInputObject)

Edit current account info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateCurrentUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var updateCurrentUserInputObject = new UpdateCurrentUserRequest(); // UpdateCurrentUserRequest | 

            try
            {
                // Edit current account info
                UpdateCurrentUserResponse result = apiInstance.UpdateCurrentUser(updateCurrentUserInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateCurrentUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCurrentUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit current account info
    ApiResponse<UpdateCurrentUserResponse> response = apiInstance.UpdateCurrentUserWithHttpInfo(updateCurrentUserInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateCurrentUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateCurrentUserInputObject** | [**UpdateCurrentUserRequest**](UpdateCurrentUserRequest.md) |  |  |

### Return type

[**UpdateCurrentUserResponse**](UpdateCurrentUserResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Updated with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecustomfield"></a>
# **UpdateCustomField**
> ResourceLinkResponse UpdateCustomField (int id, CreateCustomFieldRequest updateCustomFieldInputObject)

Edit a custom field

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var updateCustomFieldInputObject = new CreateCustomFieldRequest(); // CreateCustomFieldRequest | 

            try
            {
                // Edit a custom field
                ResourceLinkResponse result = apiInstance.UpdateCustomField(id, updateCustomFieldInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateCustomField: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomFieldWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a custom field
    ApiResponse<ResourceLinkResponse> response = apiInstance.UpdateCustomFieldWithHttpInfo(id, updateCustomFieldInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateCustomFieldWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **updateCustomFieldInputObject** | [**CreateCustomFieldRequest**](CreateCustomFieldRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when updated with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecustomfieldvalue"></a>
# **UpdateCustomFieldValue**
> ResourceLinkResponse UpdateCustomFieldValue (int id, UpdateCustomFieldValueRequest updateCustomFieldValueInputObject)

Edit the custom field value of a specified contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateCustomFieldValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 554;  // int | 
            var updateCustomFieldValueInputObject = new UpdateCustomFieldValueRequest(); // UpdateCustomFieldValueRequest | 

            try
            {
                // Edit the custom field value of a specified contact
                ResourceLinkResponse result = apiInstance.UpdateCustomFieldValue(id, updateCustomFieldValueInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateCustomFieldValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomFieldValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit the custom field value of a specified contact
    ApiResponse<ResourceLinkResponse> response = apiInstance.UpdateCustomFieldValueWithHttpInfo(id, updateCustomFieldValueInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateCustomFieldValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **updateCustomFieldValueInputObject** | [**UpdateCustomFieldValueRequest**](UpdateCustomFieldValueRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when updated with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateinboundmessagesnotificationsettings"></a>
# **UpdateInboundMessagesNotificationSettings**
> void UpdateInboundMessagesNotificationSettings (UpdateInboundMessagesNotificationSettingsRequest updateInboundMessagesNotificationSettingsInputObject)

Update inbound messages notification settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateInboundMessagesNotificationSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var updateInboundMessagesNotificationSettingsInputObject = new UpdateInboundMessagesNotificationSettingsRequest(); // UpdateInboundMessagesNotificationSettingsRequest | 

            try
            {
                // Update inbound messages notification settings
                apiInstance.UpdateInboundMessagesNotificationSettings(updateInboundMessagesNotificationSettingsInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateInboundMessagesNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInboundMessagesNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update inbound messages notification settings
    apiInstance.UpdateInboundMessagesNotificationSettingsWithHttpInfo(updateInboundMessagesNotificationSettingsInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateInboundMessagesNotificationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateInboundMessagesNotificationSettingsInputObject** | [**UpdateInboundMessagesNotificationSettingsRequest**](UpdateInboundMessagesNotificationSettingsRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Request executed with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatelist"></a>
# **UpdateList**
> ResourceLinkResponse UpdateList (int id, UpdateListRequest updateListObject = null)

Edit a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var updateListObject = new UpdateListRequest(); // UpdateListRequest |  (optional) 

            try
            {
                // Edit a list
                ResourceLinkResponse result = apiInstance.UpdateList(id, updateListObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a list
    ApiResponse<ResourceLinkResponse> response = apiInstance.UpdateListWithHttpInfo(id, updateListObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **updateListObject** | [**UpdateListRequest**](UpdateListRequest.md) |  | [optional]  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Returned when the form has errors. |  -  |
| **403** | Returned when trying to edit a list shared to a current user. |  -  |
| **404** | Returned when no list found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesendersetting"></a>
# **UpdateSenderSetting**
> void UpdateSenderSetting (UpdateSenderSettingRequest updateSenderSettingInputObject)

Change sender settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateSenderSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var updateSenderSettingInputObject = new UpdateSenderSettingRequest(); // UpdateSenderSettingRequest | 

            try
            {
                // Change sender settings
                apiInstance.UpdateSenderSetting(updateSenderSettingInputObject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateSenderSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSenderSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change sender settings
    apiInstance.UpdateSenderSettingWithHttpInfo(updateSenderSettingInputObject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateSenderSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateSenderSettingInputObject** | [**UpdateSenderSettingRequest**](UpdateSenderSettingRequest.md) |  |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Sender settings have been updated with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetemplate"></a>
# **UpdateTemplate**
> ResourceLinkResponse UpdateTemplate (int id, CreateTemplateRequest updateTemplateInputObject)

Update a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UpdateTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var updateTemplateInputObject = new CreateTemplateRequest(); // CreateTemplateRequest | 

            try
            {
                // Update a template
                ResourceLinkResponse result = apiInstance.UpdateTemplate(id, updateTemplateInputObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UpdateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a template
    ApiResponse<ResourceLinkResponse> response = apiInstance.UpdateTemplateWithHttpInfo(id, updateTemplateInputObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UpdateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **updateTemplateInputObject** | [**CreateTemplateRequest**](CreateTemplateRequest.md) |  |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Returned when the form has errors. |  -  |
| **401** | Unauthorized request. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadavatar"></a>
# **UploadAvatar**
> void UploadAvatar (System.IO.Stream image)

Upload an avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UploadAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | User avatar. Should be a PNG or JPG file not more than 10 MB.

            try
            {
                // Upload an avatar
                apiInstance.UploadAvatar(image);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UploadAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload an avatar
    apiInstance.UploadAvatarWithHttpInfo(image);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UploadAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **image** | **System.IO.Stream****System.IO.Stream** | User avatar. Should be a PNG or JPG file not more than 10 MB. |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadcontactavatar"></a>
# **UploadContactAvatar**
> ResourceLinkResponse UploadContactAvatar (int id, System.IO.Stream image)

Upload an avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UploadContactAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Contact avatar. Should be a PNG or JPG file not more than 10 MB.

            try
            {
                // Upload an avatar
                ResourceLinkResponse result = apiInstance.UploadContactAvatar(id, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UploadContactAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadContactAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload an avatar
    ApiResponse<ResourceLinkResponse> response = apiInstance.UploadContactAvatarWithHttpInfo(id, image);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UploadContactAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **image** | **System.IO.Stream****System.IO.Stream** | Contact avatar. Should be a PNG or JPG file not more than 10 MB. |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returned when successful. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a contact shared to a current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadlistavatar"></a>
# **UploadListAvatar**
> ResourceLinkResponse UploadListAvatar (int id, System.IO.Stream image)

Add an avatar for a list

Add an avatar for a list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UploadListAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var id = 1;  // int | 
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | List avatar. Should be a PNG or JPG file not more than 10 MB.

            try
            {
                // Add an avatar for a list
                ResourceLinkResponse result = apiInstance.UploadListAvatar(id, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UploadListAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadListAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add an avatar for a list
    ApiResponse<ResourceLinkResponse> response = apiInstance.UploadListAvatarWithHttpInfo(id, image);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UploadListAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **image** | **System.IO.Stream****System.IO.Stream** | List avatar. Should be a PNG or JPG file not more than 10 MB. |  |

### Return type

[**ResourceLinkResponse**](ResourceLinkResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Avatar uploaded with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |
| **403** | Returned when trying to edit a list shared to the current user. |  -  |
| **404** | Request data not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadmessageattachment"></a>
# **UploadMessageAttachment**
> UploadMessageAttachmentResponse UploadMessageAttachment (System.IO.Stream file)

Upload message attachment

Upload a new file to insert it as a link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UploadMessageAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Attachment. Supports .jpg, .gif, .png, .pdf, .txt, .csv, .doc, .docx, .xls, .xlsx, .ppt, .pptx & .vcf file formats.

            try
            {
                // Upload message attachment
                UploadMessageAttachmentResponse result = apiInstance.UploadMessageAttachment(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UploadMessageAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadMessageAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload message attachment
    ApiResponse<UploadMessageAttachmentResponse> response = apiInstance.UploadMessageAttachmentWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UploadMessageAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | Attachment. Supports .jpg, .gif, .png, .pdf, .txt, .csv, .doc, .docx, .xls, .xlsx, .ppt, .pptx &amp; .vcf file formats. |  |

### Return type

[**UploadMessageAttachmentResponse**](UploadMessageAttachmentResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File uploaded with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadmessagemmsattachment"></a>
# **UploadMessageMMSAttachment**
> UploadMessageAttachmentResponse UploadMessageMMSAttachment (System.IO.Stream file)

Upload message mms attachment

Upload a new file to mms.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using TextMagicClient.Api;
using TextMagicClient.Client;
using TextMagicClient.Model;

namespace Example
{
    public class UploadMessageMMSAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://rest.textmagic.com";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new TextMagicApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | Attachment. Supports .jpg, .gif, .png, .pdf, .txt, .csv, .doc, .docx, .xls, .xlsx, .ppt, .pptx & .vcf file formats.

            try
            {
                // Upload message mms attachment
                UploadMessageAttachmentResponse result = apiInstance.UploadMessageMMSAttachment(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TextMagicApi.UploadMessageMMSAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadMessageMMSAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload message mms attachment
    ApiResponse<UploadMessageAttachmentResponse> response = apiInstance.UploadMessageMMSAttachmentWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TextMagicApi.UploadMessageMMSAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | Attachment. Supports .jpg, .gif, .png, .pdf, .txt, .csv, .doc, .docx, .xls, .xlsx, .ppt, .pptx &amp; .vcf file formats. |  |

### Return type

[**UploadMessageAttachmentResponse**](UploadMessageAttachmentResponse.md)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File uploaded with success. |  -  |
| **400** | Bad request. |  -  |
| **401** | Unauthorized request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

