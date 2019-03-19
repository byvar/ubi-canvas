using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MenuE3Component_Template : CSerializable {
		[Serialize("maps"           )] public Placeholder maps;
		[Serialize("music"          )] public StringID music;
		[Serialize("validationSound")] public StringID validationSound;
		[Serialize("selectionSound" )] public StringID selectionSound;
		[Serialize("inGameMenu"     )] public int inGameMenu;
		[Serialize("offset2D"       )] public Vector2 offset2D;
		[Serialize("zOffset"        )] public float zOffset;
		[Serialize("pauseAnimSize"  )] public Vector2 pauseAnimSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maps));
			SerializeField(s, nameof(music));
			SerializeField(s, nameof(validationSound));
			SerializeField(s, nameof(selectionSound));
			SerializeField(s, nameof(inGameMenu));
			SerializeField(s, nameof(offset2D));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(pauseAnimSize));
		}
		public override uint? ClassCRC => 0xC115C7F0;
	}
}

