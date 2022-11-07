namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MenuE3Component_Template : CSerializable {
		public Placeholder maps;
		public StringID music;
		public StringID validationSound;
		public StringID selectionSound;
		public int inGameMenu;
		public Vec2d offset2D;
		public float zOffset;
		public Vec2d pauseAnimSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maps = s.SerializeObject<Placeholder>(maps, name: "maps");
			music = s.SerializeObject<StringID>(music, name: "music");
			validationSound = s.SerializeObject<StringID>(validationSound, name: "validationSound");
			selectionSound = s.SerializeObject<StringID>(selectionSound, name: "selectionSound");
			inGameMenu = s.Serialize<int>(inGameMenu, name: "inGameMenu");
			offset2D = s.SerializeObject<Vec2d>(offset2D, name: "offset2D");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			pauseAnimSize = s.SerializeObject<Vec2d>(pauseAnimSize, name: "pauseAnimSize");
		}
		public override uint? ClassCRC => 0xC115C7F0;
	}
}

