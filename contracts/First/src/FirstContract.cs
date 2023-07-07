using System;
using System.ComponentModel;
using System.Numerics;

using Neo;
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Attributes;
using Neo.SmartContract.Framework.Native;
using Neo.SmartContract.Framework.Services;

namespace First{
    public class FirstContract : SmartContract{
        public static void AddData(object data){
            Storage.Put(Storage.CurrentContext, "Name", "Masum");
        }

        public static string getData(){
            return Storage.Get(Storage.CurrentContext, "Name");
        }
    }
}