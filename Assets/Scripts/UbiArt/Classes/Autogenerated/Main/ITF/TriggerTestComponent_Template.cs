using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerTestComponent_Template : ActorComponent_Template {
		public CArray<sEventData> CArray_sEventData__0;
		public CArray<sEventData> CArray_sEventData__1;
		public CArray<sEventData> CArray_sEventData__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				CArray_sEventData__0 = s.SerializeObject<CArray<sEventData>>(CArray_sEventData__0, name: "CArray_sEventData__0");
				CArray_sEventData__1 = s.SerializeObject<CArray<sEventData>>(CArray_sEventData__1, name: "CArray_sEventData__1");
				CArray_sEventData__2 = s.SerializeObject<CArray<sEventData>>(CArray_sEventData__2, name: "CArray_sEventData__2");
			} else {
			}
		}
		public override uint? ClassCRC => 0x19779A51;
	}
}

