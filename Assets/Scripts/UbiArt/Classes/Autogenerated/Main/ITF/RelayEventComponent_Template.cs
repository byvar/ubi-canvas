using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RelayEventComponent_Template : ActorComponent_Template {
		[Serialize("relays")] public CList<RelayData> relays;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(relays));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class RelayData : CSerializable {
			[Serialize("Generic<Event>__0")] public Generic<Event> Generic_Event__0;
			[Serialize("Generic<Event>__1")] public Generic<Event> Generic_Event__1;
			[Serialize("float__2"         )] public float float__2;
			[Serialize("int__3"           )] public int int__3;
			[Serialize("int__4"           )] public int int__4;
			[Serialize("int__5"           )] public int int__5;
			[Serialize("int__6"           )] public int int__6;
			[Serialize("int__7"           )] public int int__7;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Generic_Event__0));
				SerializeField(s, nameof(Generic_Event__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(int__7));
			}
		}
		public override uint? ClassCRC => 0x060B7DC1;
	}
}

