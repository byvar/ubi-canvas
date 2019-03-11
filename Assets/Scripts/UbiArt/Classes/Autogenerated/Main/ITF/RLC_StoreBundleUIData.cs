using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_StoreBundleUIData : CSerializable {
		[Serialize("conditions"                 )] public CMap<uint, RLC_AutomaticPopupCondition> conditions;
		[Serialize("openingPeriods"             )] public CMap<uint, RLC_StoreBundlePeriod> openingPeriods;
		[Serialize("genericpacksloc"            )] public CMap<uint, RLC_StoreBundleLocInfo> genericpacksloc;
		[Serialize("hiddenIfPackDisplayed"      )] public CMap<uint, RLC_StoreBundle.Type> hiddenIfPackDisplayed;
		[Serialize("hiddenIfPackBought"         )] public CMap<uint, RLC_StoreBundle.Type> hiddenIfPackBought;
		[Serialize("scrollableButtonPath"       )] public PathRef scrollableButtonPath;
		[Serialize("InfoMenuCRC"                )] public StringID InfoMenuCRC;
		[Serialize("PurchasedMenuCRC"           )] public StringID PurchasedMenuCRC;
		[Serialize("popupPriority"              )] public uint popupPriority;
		[Serialize("uniquePurchase"             )] public bool uniquePurchase;
		[Serialize("OnlyIfCollectionNotComplete")] public bool OnlyIfCollectionNotComplete;
		[Serialize("PayerOnly"                  )] public bool PayerOnly;
		[Serialize("NonPayerOnly"               )] public bool NonPayerOnly;
		[Serialize("HiddenIfTimeSaverActive"    )] public bool HiddenIfTimeSaverActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(conditions));
			SerializeField(s, nameof(openingPeriods));
			SerializeField(s, nameof(genericpacksloc));
			SerializeField(s, nameof(hiddenIfPackDisplayed));
			SerializeField(s, nameof(hiddenIfPackBought));
			SerializeField(s, nameof(scrollableButtonPath));
			SerializeField(s, nameof(InfoMenuCRC));
			SerializeField(s, nameof(PurchasedMenuCRC));
			SerializeField(s, nameof(popupPriority));
			SerializeField(s, nameof(uniquePurchase));
			SerializeField(s, nameof(OnlyIfCollectionNotComplete));
			SerializeField(s, nameof(PayerOnly));
			SerializeField(s, nameof(NonPayerOnly));
			SerializeField(s, nameof(HiddenIfTimeSaverActive));
		}
	}
}

