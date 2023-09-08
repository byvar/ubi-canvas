namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class TriggerTestComponent_Template : ActorComponent_Template {
		public CArrayO<sEventData> CArray_sEventData__0;
		public CArrayO<sEventData> CArray_sEventData__1;
		public CArrayO<sEventData> CArray_sEventData__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.VH) {
				CArray_sEventData__0 = s.SerializeObject<CArrayO<sEventData>>(CArray_sEventData__0, name: "CArray<sEventData>__0");
				CArray_sEventData__1 = s.SerializeObject<CArrayO<sEventData>>(CArray_sEventData__1, name: "CArray<sEventData>__1");
				CArray_sEventData__2 = s.SerializeObject<CArrayO<sEventData>>(CArray_sEventData__2, name: "CArray<sEventData>__2");
			} else {
			}
		}
		public override uint? ClassCRC => 0x19779A51;
	}
}

