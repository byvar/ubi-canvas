using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_FlareGenerator : ActorComponent {
		[Serialize("float__0"                 )] public float float__0;
		[Serialize("int__1"                   )] public int int__1;
		[Serialize("Path__2"                  )] public Path Path__2;
		[Serialize("Generic<Event>__3"        )] public Generic<Event> Generic_Event__3;
		[Serialize("CArray<Generic<Event>>__4")] public CArray<Generic<Event>> CArray_Generic_Event__4;
		[Serialize("CArray<Generic<Event>>__5")] public CArray<Generic<Event>> CArray_Generic_Event__5;
		[Serialize("CArray<Generic<Event>>__6")] public CArray<Generic<Event>> CArray_Generic_Event__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(int__1));
			SerializeField(s, nameof(Path__2));
			SerializeField(s, nameof(Generic_Event__3));
			SerializeField(s, nameof(CArray_Generic_Event__4));
			SerializeField(s, nameof(CArray_Generic_Event__5));
			SerializeField(s, nameof(CArray_Generic_Event__6));
		}
		public override uint? ClassCRC => 0xA0D8140F;
	}
}

