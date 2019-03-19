using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTestComponent_Template : ActorComponent_Template {
		[Serialize("CArray<sEventData>__0")] public CArray<sEventData> CArray_sEventData__0;
		[Serialize("CArray<sEventData>__1")] public CArray<sEventData> CArray_sEventData__1;
		[Serialize("CArray<sEventData>__2")] public CArray<sEventData> CArray_sEventData__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_sEventData__0));
				SerializeField(s, nameof(CArray_sEventData__1));
				SerializeField(s, nameof(CArray_sEventData__2));
			} else {
			}
		}
		public override uint? ClassCRC => 0x19779A51;
	}
}

