﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 
namespace EInv.Models.EInv.v32.B2BST.EInvoice
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:GEINV:eInvoiceMessage:A0501:3.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:GEINV:eInvoiceMessage:A0501:3.2", IsNullable = false)]
    public partial class CancelInvoice
    {

        private string cancelInvoiceNumberField;

        private string invoiceDateField;

        private string buyerIdField;

        private string sellerIdField;

        private string cancelDateField;

        private System.DateTime cancelTimeField;

        private string cancelReasonField;

        private string returnTaxDocumentNumberField;

        private string remarkField;

        /// <remarks/>
        public string CancelInvoiceNumber
        {
            get
            {
                return this.cancelInvoiceNumberField;
            }
            set
            {
                this.cancelInvoiceNumberField = value;
            }
        }

        /// <remarks/>
        public string InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        public string BuyerId
        {
            get
            {
                return this.buyerIdField;
            }
            set
            {
                this.buyerIdField = value;
            }
        }

        /// <remarks/>
        public string SellerId
        {
            get
            {
                return this.sellerIdField;
            }
            set
            {
                this.sellerIdField = value;
            }
        }

        /// <remarks/>
        public string CancelDate
        {
            get
            {
                return this.cancelDateField;
            }
            set
            {
                this.cancelDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime CancelTime
        {
            get
            {
                return this.cancelTimeField;
            }
            set
            {
                this.cancelTimeField = value;
            }
        }

        /// <remarks/>
        public string CancelReason
        {
            get
            {
                return this.cancelReasonField;
            }
            set
            {
                this.cancelReasonField = value;
            }
        }

        /// <remarks/>
        public string ReturnTaxDocumentNumber
        {
            get
            {
                return this.returnTaxDocumentNumberField;
            }
            set
            {
                this.returnTaxDocumentNumberField = value;
            }
        }

        /// <remarks/>
        public string Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                this.remarkField = value;
            }
        }
    }
}