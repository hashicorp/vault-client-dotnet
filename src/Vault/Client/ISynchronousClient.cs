// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.


using System;
using System.IO;

namespace Vault.Client
{
    /// <summary>
    /// Contract for Synchronous RESTful API interactions.
    ///
    /// This interface allows consumers to provide a custom API accessor client.
    /// </summary>
    public interface ISynchronousClient
    {
        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the GET http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Get<T>(string path, RequestOptions options);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the POST http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Post<T>(string path, RequestOptions options);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the PUT http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Put<T>(string path, RequestOptions options);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the DELETE http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Delete<T>(string path, RequestOptions options);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the HEAD http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Head<T>(string path, RequestOptions options);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the OPTIONS http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Options<T>(string path, RequestOptions options);

        /// <summary>
        /// Executes a blocking call to some <paramref name="path"/> using the PATCH http verb.
        /// </summary>
        /// <param name="path">The relative path to invoke.</param>
        /// <param name="options">The request parameters to pass along to the client.</param>
        /// <typeparam name="T">The return type.</typeparam>
        /// <returns>The response data, decorated with <see cref="ApiResponse{T}"/></returns>
        ApiResponse<T> Patch<T>(string path, RequestOptions options);
    }
}
