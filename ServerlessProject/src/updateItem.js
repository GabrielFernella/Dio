"use strict";

const AWS = require("aws-sdk")

const updateItem = async (event) => {

  const {itemStatus} = JSON.parse(event.body);
  const {id} = event.pathParameters

  const dynamodb = new AWS.DynamoDB.DocumentClient();

  try {
    await dynamodb.update({
      TableName: "ItemTable",
      Key: {id},
      UpdateExpression: 'set itemStatus = :itemStatus',
      ExpressionAttributeValues: {
        ':itemStatus': itemStatus
      },
      ReturnValues: "ALL_NEW"
    }).promise()
    
  } catch (error) {
    console.log(error)
    return {
      statusCode: 400,
      body: error,
  };
  }

  return {
    statusCode: 200,
    body: JSON.stringify(
      { msg: 'Item updated'}
    ),
  };
};


module.exports = {
    handler:updateItem
}


