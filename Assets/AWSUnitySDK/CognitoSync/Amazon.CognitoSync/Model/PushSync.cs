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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Configuration options to be applied to the identity pool.
    /// </summary>
    public partial class PushSync
    {
        private List<string> _applicationArns = new List<string>();
        private string _roleArn;


        /// <summary>
        /// Gets and sets the property ApplicationArns. 
        /// <para>
        /// List of SNS platform application ARNs that could be used by clients.
        /// </para>
        /// </summary>
        public List<string> ApplicationArns
        {
            get { return this._applicationArns; }
            set { this._applicationArns = value; }
        }

        // Check to see if ApplicationArns property is set
        internal bool IsSetApplicationArns()
        {
            return this._applicationArns != null && this._applicationArns.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A role configured to allow Cognito to call SNS on behalf of the developer.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}