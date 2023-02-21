
# AssetManagementBackend

This API functions as the backend for my modular Asset Management System.


## API Reference

These are the controllers and corresponding calls you can make to this API. Schemas are included per call.

## Asset Controller
<details><summary>Controller Calls</summary>

### Get All Assets
<details><summary>Call Details</summary>

```
  GET /api/Asset
```

#### Response Body

```yaml
"id": 0,
"name": "string",
"iconId": 0,
"userRelation": 0
```
---
</details>

### Get Asset
<details><summary>Call Details</summary>

```
  GET /api/Asset/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of Asset to fetch |

#### Response Body

```yaml
"id": 0,
"name": "string",
"iconId": 0,
"userRelation": 0
```
---
</details>

### Delete Asset
<details><summary>Call Details</summary>

```
  DELETE /api/Asset/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of Asset to delete |

#### Return Body

```yaml
Integer
```
---
</details>

### Create Asset
<details><summary>Call Details</summary>

```
  POST /api/Asset
```

#### Request Body

```yaml
"name": "string",
"iconId": 0,
"userRelation": 0
```
---
</details>

### Update Asset
<details><summary>Call Details</summary>

```
  PUT /api/Asset{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of Asset to update |

Do note that the Id is also required in the Request body to properly update the Asset. If an Asset with that Id does not exist, then one will be created.

#### Request Body

```yaml
"id": 0,
"assetAssociation": 0,
"columnName": "string",
"value": "string"
```
---
</details>
</details>

## AssetDetail Controller
<details><summary>Controller Calls</summary>

### Get All AssetDetails
<details><summary>Call Details</summary>

```
  GET /api/AssetDetail
```

#### Response Body

```yaml
"id": 0,
"assetAssociation": 0,
"columnName": "string",
"value": "string"
```
---
</details>

### Get AssetDetail
<details><summary>Call Details</summary>

```
  GET /api/AssetDetail/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the AssetDetail to fetch |

#### Response Body

```yaml
"id": 0,
"assetAssociation": 0,
"columnName": "string",
"value": "string"
```
---
</details>
### Delete AssetDetail
<details><summary>Call Details</summary>

```
  DELETE /api/AssetDetail/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the AssetDetail to delete |

#### Return Body

```yaml
Integer
```
---
</details>
### Create AssetDetail
<details><summary>Call Details</summary>

```
  POST /api/AssetDetail
```

#### Request Body

```yaml
"assetAssociation": 0,
"columnName": "string",
"value": "string"
```
---
</details>
### Update AssetDetail
<details><summary>Call Details</summary>

```
  PUT /api/AssetDetail{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the AssetDetail to update |

Do note that the Id is also required in the Request body to properly update the AssetDetail. If an AssetDetail with that Id does not exist, then one will be created.

#### Request Body

```yaml
"id": 0,
"assetAssociation": 0,
"columnName": "string",
"value": "string"
```
---
</details>
</details>

## Icon Controller
<details><summary>Controller Calls</summary>

### Get All Icons
<details><summary>Call Details</summary>

```
  GET /api/Icon
```

#### Response Body

```yaml
"id": 0,
"iconName": "string"
```
---
</details>

### Get Icon
<details><summary>Call Details</summary>

```
  GET /api/Icon/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the Icon to fetch |

#### Response Body

```yaml
"id": 0,
"iconName": "string"
```
---
</details>
### Delete Icon
<details><summary>Call Details</summary>

```
  DELETE /api/Icon/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the Icon to delete |

#### Return Body

```yaml
Integer
```
---
</details>
### Create Icon
<details><summary>Call Details</summary>

```
  POST /api/Icon
```

#### Request Body

```yaml
"iconName": "string"
```
---
</details>
### Update Icon
<details><summary>Call Details</summary>

```
  PUT /api/Icon/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the Icon to update |

Do note that the Id is also required in the Request body to properly update the Icon. If an Icon with that Id does not exist, then one will be created.

#### Request Body

```yaml
"id": 0,
"iconName": "string"
```
---
</details>
</details>

## User Controller
<details><summary>Controller Calls</summary>

### Get All Users
<details><summary>Call Details</summary>

```
  GET /api/User
```

#### Response Body

```yaml
"id": 0,
"firstName": "string",
"lastName": "string",
"userName": "string"
```
---
</details>

### Get User
<details><summary>Call Details</summary>

```
  GET /api/User/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the User to fetch |

#### Response Body

```yaml
"id": 0,
"firstName": "string",
"lastName": "string",
"userName": "string"
```
---
</details>
### Delete User
<details><summary>Call Details</summary>

```
  DELETE /api/User/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the User to delete |

#### Return Body

```yaml
Integer
```
---
</details>
### Create User
<details><summary>Call Details</summary>

```
  POST /api/User
```

#### Request Body

```yaml
"firstName": "string",
"lastName": "string",
"userName": "string"
```
---
</details>
### Update User
<details><summary> Call Details</summary>

```
  PUT /api/Icon/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `Integer` | **Required:** Id of the User to update |

Do note that the Id is also required in the Request body to properly update the User. If an User with that Id does not exist, then one will be created.

#### Request Body

```yaml
"id": 0,
"firstName": "string",
"lastName": "string",
"userName": "string"
```
---
</details>
</details>










