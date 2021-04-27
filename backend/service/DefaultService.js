"use strict";

/**
 * Delete Product
 *
 * id Long Product ID
 * no response value expected for this operation
 **/
exports.deleteProductById = function (id) {
  return new Promise(function (resolve, reject) {
    resolve();
  });
};

/**
 * Get product by ID
 * This is description only
 *
 * id Long Product ID
 * returns Product
 **/
exports.getProductById = function (id) {
  return new Promise(function (resolve, reject) {
    var examples = {};
    examples["application/json"] = {
      price: 12.78,
      name_print: "W G Ball",
      name_display: "White Golf Ball",
      description: "White Golf Ball Adamns Co",
      tax: 0.05,
      id: 123,
    };
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
};

/**
 * Server heartbeat operation
 * This operation shows how to override the global security defined above, as we want to open it up for all users.
 *
 * no response value expected for this operation
 **/
exports.helthCheck = function () {
  return new Promise(function (resolve, reject) {
    resolve();
  });
};

/**
 * List all products
 * List all products description
 *
 * returns List
 **/
exports.listProducts = function () {
  return new Promise(function (resolve, reject) {
    var examples = {};
    examples["application/json"] = [
      {
        price: 12.78,
        name_print: "W G Ball",
        name_display: "White Golf Ball",
        description: "White Golf Ball Adamns Co",
        tax: 0.05,
        id: 123,
      },
      {
        price: 12.78,
        name_print: "W G Ball",
        name_display: "White Golf Ball",
        description: "White Golf Ball Adamns Co",
        tax: 0.05,
        id: 123,
      },
    ];
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
};

/**
 * Save a product
 * This is description only
 *
 * body Product  (optional)
 * no response value expected for this operation
 **/
exports.saveProduct = function (body) {
  return new Promise(function (resolve, reject) {
    resolve();
  });
};

/**
 * Update Product
 *
 * no response value expected for this operation
 **/
exports.updateProduct = function () {
  return new Promise(function (resolve, reject) {
    resolve();
  });
};
