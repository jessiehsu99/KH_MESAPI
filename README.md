# LITEON WEBAPI TEMPLATE

Line 1 - Add by James

ADD, 2019-06-10
<http://git001/GavinYen/webapi.git>

## 1. DOWNLOAD API TEMPLATE PROJECT

![API DOWNLOAD](/img/API Download.PNG)

NOTE: DO NOT SYNC. to this Project.

## 2. CREATE DB, NAME: WebAPI AND TABLE: [API_Auth] / [API_Control]

REF: DBSchema/WebAPI.sql

## 3. TRY TO RE-BUILD and PUBLISH USING IDE of THE VISUAL STUDIO 2015.


## 4. FINALLY, CREATE PUBLISH API IN IIS(.NET FRANKWORK 4.5).


## 5. TEST API URL

http://{HOSTNAME}/{PUBLISH SITE}/swagger-ui-master/dist/index.html

## 6. AUTHORIZATION CONFIG

### TABLE: API_Auth, CREATE AND AUTHORIZE API ACCOUNT 
<table>
    <tr>
        <td>AppID</td>
		<td>UserName</td>
		<td>PWD</td>
    </tr>
	<tr>
        <td>AP1</td>
		<td>AP</td>
		<td>AP</td>
    </tr>
</table>

##### AS BELOW LOGONID
![API DOWNLOAD](/img/API_Logoin.PNG)

### TABLE: API_Control, ALLOW API ACCOUNT TO ACCESS API FUNCTIONS 
<table>
    <tr>
        <td>AppID</td>
		<td>Control</td>
		<td>Action</td>
    </tr>
	<tr>
        <td>AP1</td>
		<td>TestServices</td>
		<td>*</td>
    </tr>
</table>

### WORKFLOW AUTHORITY (AppID = wf, UserName = PLAN NAME, PWD = PLANSN)

![API DOWNLOAD](/img/wf.PNG)

## 7. API KEY AUTHORIZATION IN SWAGGER UI
### Bearer [API KEY] 
![API DOWNLOAD](/img/Swagger.PNG)
