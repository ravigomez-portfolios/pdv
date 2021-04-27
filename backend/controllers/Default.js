"use strict";

var utils = require("../utils/writer.js");
var Default = require("../service/DefaultService");

module.exports.deleteProductById = function deleteProductById(
  req,
  res,
  next,
  id
) {
  Default.deleteProductById(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.getProductById = function getProductById(req, res, next, id) {
  Default.getProductById(id)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.helthCheck = function helthCheck(req, res, next) {
  Default.helthCheck()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.listProducts = function listProducts(req, res, next) {
  Default.listProducts()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.saveProduct = function saveProduct(req, res, next, body) {
  Default.saveProduct(body)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.updateProduct = function updateProduct(req, res, next) {
  Default.updateProduct()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
