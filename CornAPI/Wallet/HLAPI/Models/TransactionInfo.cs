﻿using System;

namespace CornAPI.Wallet.HLAPI.Models
{
    /// <summary>
    /// Deserialized Transaction info response returned by the gettransaction call
    /// </summary>
    [Serializable]
    public class TransactionInfo
    {

        public double amount { get; set; }

        public double confirmations { get; set; }

        public bool generated { get; set; }

        public string blockhash { get; set; }

        public double blockindex { get; set; }

        public long blocktime { get; set; }

        public string txid { get; set; }

        public object[] walletconflicts { get; set; }

        public long time { get; set; }

        public long timereceived { get; set; }

        public TransactionInfoDetail[] details { get; set; }

        public string hex { get; set; }

    }
}
