using NBitcoin;

namespace NBXplorer
{
	public partial class NBXplorerNetworkProvider
	{
		private void InitMonetaryUnit(ChainName networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.MonetaryUnit.Instance, networkType)
			{
				MinRPCVersion = 70702
			});
		}

		public NBXplorerNetwork GetMUE()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.MonetaryUnit.Instance.CryptoCode);
		}
	}
}
