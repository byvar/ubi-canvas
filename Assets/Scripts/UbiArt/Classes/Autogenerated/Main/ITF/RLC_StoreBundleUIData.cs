using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_StoreBundleUIData : CSerializable {
		public CMap<uint, RLC_AutomaticPopupCondition> conditions;
		public CMap<uint, RLC_StoreBundlePeriod> openingPeriods;
		public CMap<uint, RLC_StoreBundleLocInfo> genericpacksloc;
		public CMap<uint, RLC_StoreBundle.Type> hiddenIfPackDisplayed;
		public CMap<uint, RLC_StoreBundle.Type> hiddenIfPackBought;
		public PathRef scrollableButtonPath;
		public StringID InfoMenuCRC;
		public StringID PurchasedMenuCRC;
		public uint popupPriority;
		public bool uniquePurchase;
		public bool OnlyIfCollectionNotComplete;
		public bool PayerOnly;
		public bool NonPayerOnly;
		public bool HiddenIfTimeSaverActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			conditions = s.SerializeObject<CMap<uint, RLC_AutomaticPopupCondition>>(conditions, name: "conditions");
			openingPeriods = s.SerializeObject<CMap<uint, RLC_StoreBundlePeriod>>(openingPeriods, name: "openingPeriods");
			genericpacksloc = s.SerializeObject<CMap<uint, RLC_StoreBundleLocInfo>>(genericpacksloc, name: "genericpacksloc");
			hiddenIfPackDisplayed = s.SerializeObject<CMap<uint, RLC_StoreBundle.Type>>(hiddenIfPackDisplayed, name: "hiddenIfPackDisplayed");
			hiddenIfPackBought = s.SerializeObject<CMap<uint, RLC_StoreBundle.Type>>(hiddenIfPackBought, name: "hiddenIfPackBought");
			scrollableButtonPath = s.SerializeObject<PathRef>(scrollableButtonPath, name: "scrollableButtonPath");
			InfoMenuCRC = s.SerializeObject<StringID>(InfoMenuCRC, name: "InfoMenuCRC");
			PurchasedMenuCRC = s.SerializeObject<StringID>(PurchasedMenuCRC, name: "PurchasedMenuCRC");
			popupPriority = s.Serialize<uint>(popupPriority, name: "popupPriority");
			uniquePurchase = s.Serialize<bool>(uniquePurchase, name: "uniquePurchase");
			OnlyIfCollectionNotComplete = s.Serialize<bool>(OnlyIfCollectionNotComplete, name: "OnlyIfCollectionNotComplete");
			PayerOnly = s.Serialize<bool>(PayerOnly, name: "PayerOnly");
			NonPayerOnly = s.Serialize<bool>(NonPayerOnly, name: "NonPayerOnly");
			HiddenIfTimeSaverActive = s.Serialize<bool>(HiddenIfTimeSaverActive, name: "HiddenIfTimeSaverActive");
		}
	}
}

