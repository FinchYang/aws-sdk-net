/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// The association between a direct connect gateway and virtual interface.
    /// </summary>
    public partial class DirectConnectGatewayAttachment
    {
        private DirectConnectGatewayAttachmentState _attachmentState;
        private string _directConnectGatewayId;
        private string _stateChangeError;
        private string _virtualInterfaceId;
        private string _virtualInterfaceOwnerAccount;
        private string _virtualInterfaceRegion;

        /// <summary>
        /// Gets and sets the property AttachmentState.
        /// </summary>
        public DirectConnectGatewayAttachmentState AttachmentState
        {
            get { return this._attachmentState; }
            set { this._attachmentState = value; }
        }

        // Check to see if AttachmentState property is set
        internal bool IsSetAttachmentState()
        {
            return this._attachmentState != null;
        }

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId.
        /// </summary>
        public string DirectConnectGatewayId
        {
            get { return this._directConnectGatewayId; }
            set { this._directConnectGatewayId = value; }
        }

        // Check to see if DirectConnectGatewayId property is set
        internal bool IsSetDirectConnectGatewayId()
        {
            return this._directConnectGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property StateChangeError.
        /// </summary>
        public string StateChangeError
        {
            get { return this._stateChangeError; }
            set { this._stateChangeError = value; }
        }

        // Check to see if StateChangeError property is set
        internal bool IsSetStateChangeError()
        {
            return this._stateChangeError != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId.
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceOwnerAccount. 
        /// <para>
        /// The AWS account ID of the owner of the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceOwnerAccount
        {
            get { return this._virtualInterfaceOwnerAccount; }
            set { this._virtualInterfaceOwnerAccount = value; }
        }

        // Check to see if VirtualInterfaceOwnerAccount property is set
        internal bool IsSetVirtualInterfaceOwnerAccount()
        {
            return this._virtualInterfaceOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceRegion.
        /// </summary>
        public string VirtualInterfaceRegion
        {
            get { return this._virtualInterfaceRegion; }
            set { this._virtualInterfaceRegion = value; }
        }

        // Check to see if VirtualInterfaceRegion property is set
        internal bool IsSetVirtualInterfaceRegion()
        {
            return this._virtualInterfaceRegion != null;
        }

    }
}