// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices
{
    public static partial class VaultOperationsExtensions
    {
        /// <summary>
        /// Updates vault storage model type.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IVaultOperations.
        /// </param>
        /// <param name='updateVaultStorageTypeRequest'>
        /// Required. Update Vault Storage Type Request
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static OperationResponse UpdateStorageType(this IVaultOperations operations, UpdateVaultStorageTypeRequest updateVaultStorageTypeRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).UpdateStorageTypeAsync(updateVaultStorageTypeRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates vault storage model type.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IVaultOperations.
        /// </param>
        /// <param name='updateVaultStorageTypeRequest'>
        /// Required. Update Vault Storage Type Request
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a Operation Response.
        /// </returns>
        public static Task<OperationResponse> UpdateStorageTypeAsync(this IVaultOperations operations, UpdateVaultStorageTypeRequest updateVaultStorageTypeRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UpdateStorageTypeAsync(updateVaultStorageTypeRequest, customRequestHeaders, CancellationToken.None);
        }
        
        /// <summary>
        /// Uploads vault credential certificate.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IVaultOperations.
        /// </param>
        /// <param name='certificateName'>
        /// Required. Name of the certificate.
        /// </param>
        /// <param name='vaultCredUploadCertRequest'>
        /// Required. Certificate parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a certificate response.
        /// </returns>
        public static VaultCredUploadCertResponse UploadCertificate(this IVaultOperations operations, string certificateName, VaultCredUploadCertRequest vaultCredUploadCertRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVaultOperations)s).UploadCertificateAsync(certificateName, vaultCredUploadCertRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Uploads vault credential certificate.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.BackupServices.IVaultOperations.
        /// </param>
        /// <param name='certificateName'>
        /// Required. Name of the certificate.
        /// </param>
        /// <param name='vaultCredUploadCertRequest'>
        /// Required. Certificate parameters.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// The definition of a certificate response.
        /// </returns>
        public static Task<VaultCredUploadCertResponse> UploadCertificateAsync(this IVaultOperations operations, string certificateName, VaultCredUploadCertRequest vaultCredUploadCertRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.UploadCertificateAsync(certificateName, vaultCredUploadCertRequest, customRequestHeaders, CancellationToken.None);
        }
    }
}
