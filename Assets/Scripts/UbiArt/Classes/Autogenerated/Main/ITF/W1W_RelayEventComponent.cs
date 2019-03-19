using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_RelayEventComponent : ActorComponent {
		[Serialize("CArray<W1W_RelayEventComponent.RelayData>__0")] public CArray<W1W_RelayEventComponent.RelayData> CArray_W1W_RelayEventComponent_RelayData__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_W1W_RelayEventComponent_RelayData__0));
		}
		[Games(GameFlags.VH)]
		public partial class RelayData : CSerializable {
			[Serialize("Generic<Event>__0"        )] public Generic<Event> Generic_Event__0;
			[Serialize("CArray<Generic<Event>>__1")] public CArray<Generic<Event>> CArray_Generic_Event__1;
			[Serialize("float__2"                 )] public float float__2;
			[Serialize("uint__3"                  )] public uint uint__3;
			[Serialize("bool__4"                  )] public bool bool__4;
			[Serialize("bool__5"                  )] public bool bool__5;
			[Serialize("bool__6"                  )] public bool bool__6;
			[Serialize("bool__7"                  )] public bool bool__7;
			[Serialize("bool__8"                  )] public bool bool__8;
			[Serialize("bool__9"                  )] public bool bool__9;
			[Serialize("bool__10"                 )] public bool bool__10;
			[Serialize("bool__11"                 )] public bool bool__11;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Generic_Event__0));
				SerializeField(s, nameof(CArray_Generic_Event__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
			}
		}
		public override uint? ClassCRC => 0xF9EC95CA;
	}
}

