using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuScroll : UIMenuBasic {
		[Serialize("itemOffset"       )] public Vector2 itemOffset;
		[Serialize("itemVisiblesCount")] public int itemVisiblesCount;
		[Serialize("displayOutItems"  )] public bool displayOutItems;
		[Serialize("separatorModel"   )] public StringID separatorModel;
		[Serialize("itemStartPos"     )] public Vector3 itemStartPos;
		[Serialize("separatorStartPos")] public Vector3 separatorStartPos;
		[Serialize("spawnRequestIndex")] public CArray<uint> spawnRequestIndex;
		[Serialize("itemVisiblesCount")] public bool itemVisiblesCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(itemOffset));
				SerializeField(s, nameof(itemVisiblesCount));
				SerializeField(s, nameof(displayOutItems));
				SerializeField(s, nameof(separatorModel));
				SerializeField(s, nameof(itemStartPos));
				SerializeField(s, nameof(separatorStartPos));
			} else {
				SerializeField(s, nameof(itemOffset));
				SerializeField(s, nameof(itemVisiblesCount));
				SerializeField(s, nameof(displayOutItems));
				SerializeField(s, nameof(separatorModel));
				SerializeField(s, nameof(itemStartPos));
				SerializeField(s, nameof(separatorStartPos));
				SerializeField(s, nameof(spawnRequestIndex));
			}
		}
		public override uint? ClassCRC => 0x0B43C905;
	}
}

