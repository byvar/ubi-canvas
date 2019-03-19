using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_PersistentGameData_Universe : PersistentGameData_Universe {
		[Serialize("bool__0"                                     )] public bool bool__0;
		[Serialize("uint__1"                                     )] public uint uint__1;
		[Serialize("uint__2"                                     )] public uint uint__2;
		[Serialize("uint__3"                                     )] public uint uint__3;
		[Serialize("uint__4"                                     )] public uint uint__4;
		[Serialize("bool__5"                                     )] public bool bool__5;
		[Serialize("bool__6"                                     )] public bool bool__6;
		[Serialize("bool__7"                                     )] public bool bool__7;
		[Serialize("bool__8"                                     )] public bool bool__8;
		[Serialize("bool__9"                                     )] public bool bool__9;
		[Serialize("bool__10"                                    )] public bool bool__10;
		[Serialize("bool__11"                                    )] public bool bool__11;
		[Serialize("bool__12"                                    )] public bool bool__12;
		[Serialize("bool__13"                                    )] public bool bool__13;
		[Serialize("bool__14"                                    )] public bool bool__14;
		[Serialize("bool__15"                                    )] public bool bool__15;
		[Serialize("Path__16"                                    )] public Path Path__16;
		[Serialize("uint__17"                                    )] public uint uint__17;
		[Serialize("uint__18"                                    )] public uint uint__18;
		[Serialize("uint__19"                                    )] public uint uint__19;
		[Serialize("W1W_PersistentGameData_Universe.NodeData__20")] public W1W_PersistentGameData_Universe.NodeData W1W_PersistentGameData_Universe_NodeData__20;
		[Serialize("MenuOptionSave__21"                          )] public MenuOptionSave MenuOptionSave__21;
		[Serialize("bool__22"                                    )] public bool bool__22;
		[Serialize("uint__23"                                    )] public uint uint__23;
		[Serialize("float__24"                                   )] public float float__24;
		[Serialize("bool__25"                                    )] public bool bool__25;
		[Serialize("CharactersDiariesSave__26"                   )] public CharactersDiariesSave CharactersDiariesSave__26;
		[Serialize("bool__27"                                    )] public bool bool__27;
		[Serialize("bool__28"                                    )] public bool bool__28;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(uint__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(uint__3));
			SerializeField(s, nameof(uint__4));
			SerializeField(s, nameof(bool__5));
			SerializeField(s, nameof(bool__6));
			SerializeField(s, nameof(bool__7));
			SerializeField(s, nameof(bool__8));
			SerializeField(s, nameof(bool__9));
			SerializeField(s, nameof(bool__10));
			SerializeField(s, nameof(bool__11));
			SerializeField(s, nameof(bool__12));
			SerializeField(s, nameof(bool__13));
			SerializeField(s, nameof(bool__14));
			SerializeField(s, nameof(bool__15));
			SerializeField(s, nameof(Path__16));
			SerializeField(s, nameof(uint__17));
			SerializeField(s, nameof(uint__18));
			SerializeField(s, nameof(uint__19));
			SerializeField(s, nameof(W1W_PersistentGameData_Universe_NodeData__20));
			SerializeField(s, nameof(MenuOptionSave__21));
			SerializeField(s, nameof(bool__22));
			SerializeField(s, nameof(uint__23));
			SerializeField(s, nameof(float__24));
			SerializeField(s, nameof(bool__25));
			SerializeField(s, nameof(CharactersDiariesSave__26));
			SerializeField(s, nameof(bool__27));
			SerializeField(s, nameof(bool__28));
		}
		[Games(GameFlags.VH)]
		public partial class NodeData : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("bool__1"    )] public bool bool__1;
			[Serialize("bool__2"    )] public bool bool__2;
			[Serialize("bool__3"    )] public bool bool__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
			}
		}
		public override uint? ClassCRC => 0x99632934;
	}
}

