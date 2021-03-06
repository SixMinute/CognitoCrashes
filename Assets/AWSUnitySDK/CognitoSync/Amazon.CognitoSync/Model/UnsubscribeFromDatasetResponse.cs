/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */

using System;

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Configuration for accessing Amazon UnsubscribeFromDataset service
    /// </summary>
    public partial class UnsubscribeFromDatasetResponse : UnsubscribeFromDatasetResult
    {
        /// <summary>
        /// Gets and sets the UnsubscribeFromDatasetResult property.
        /// Represents the output of a UnsubscribeFromDataset operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the UnsubscribeFromDatasetResult class are now available on the UnsubscribeFromDatasetResponse class. You should use the properties on UnsubscribeFromDatasetResponse instead of accessing them through UnsubscribeFromDatasetResult.")]
        public UnsubscribeFromDatasetResult UnsubscribeFromDatasetResult
        {
            get
            {
                return this;
            }
        }
    }
}