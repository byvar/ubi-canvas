using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DigRegionComponent_Template : ActorComponent_Template {
		[Serialize("MaterialDig"             )] public GFXMaterialSerializable MaterialDig;
		[Serialize("MaterialPlump"           )] public GFXMaterialSerializable MaterialPlump;
		[Serialize("MaterialBorder"          )] public GFXMaterialSerializable MaterialBorder;
		[Serialize("BorderHeight"            )] public float BorderHeight;
		[Serialize("BorderVisualOffset"      )] public float BorderVisualOffset;
		[Serialize("BorderBig_TileCount"     )] public float BorderBig_TileCount;
		[Serialize("BorderSmall_TileCount"   )] public float BorderSmall_TileCount;
		[Serialize("MaterialBackGround"      )] public GFXMaterialSerializable MaterialBackGround;
		[Serialize("MaterialFill"            )] public GFXMaterialSerializable MaterialFill;
		[Serialize("MaterialFillBorder"      )] public GFXMaterialSerializable MaterialFillBorder;
		[Serialize("GameMaterial"            )] public Path GameMaterial;
		[Serialize("diggingHoldFX"           )] public StringID diggingHoldFX;
		[Serialize("diggingBackHoldFX"       )] public StringID diggingBackHoldFX;
		[Serialize("diggingBackStopFX"       )] public StringID diggingBackStopFX;
		[Serialize("diggingWrongFX"          )] public StringID diggingWrongFX;
		[Serialize("soundTimeBeforeStop"     )] public float soundTimeBeforeStop;
		[Serialize("diggingHoldEnemyFX"      )] public StringID diggingHoldEnemyFX;
		[Serialize("soundTimeEnemyBeforeStop")] public float soundTimeEnemyBeforeStop;
		[Serialize("diggingParticlesFX"      )] public StringID diggingParticlesFX;
		[Serialize("fillingParticlesFX"      )] public StringID fillingParticlesFX;
		[Serialize("BorderFill"              )] public Border BorderFill;
		[Serialize("Use_backGround"          )] public bool Use_backGround;
		[Serialize("UseExtremity"            )] public bool UseExtremity;
		[Serialize("OffsetExtremityIntact"   )] public float OffsetExtremityIntact;
		[Serialize("OffsetExtremityDamaged"  )] public float OffsetExtremityDamaged;
		[Serialize("MergeCount"              )] public uint MergeCount;
		[Serialize("LumsShapeOffset"         )] public Vec2d LumsShapeOffset;
		[Serialize("LumsRadius"              )] public float LumsRadius;
		[Serialize("LumsAnticipation"        )] public float LumsAnticipation;
		[Serialize("LumsCountMaxByChain"     )] public uint LumsCountMaxByChain;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(MaterialDig));
				SerializeField(s, nameof(MaterialPlump));
				SerializeField(s, nameof(MaterialBorder));
				SerializeField(s, nameof(BorderHeight));
				SerializeField(s, nameof(BorderVisualOffset));
				SerializeField(s, nameof(BorderBig_TileCount));
				SerializeField(s, nameof(BorderSmall_TileCount));
			}
			SerializeField(s, nameof(MaterialBackGround));
			SerializeField(s, nameof(MaterialFill));
			SerializeField(s, nameof(MaterialFillBorder));
			SerializeField(s, nameof(GameMaterial));
			SerializeField(s, nameof(diggingHoldFX));
			SerializeField(s, nameof(diggingBackHoldFX));
			SerializeField(s, nameof(diggingBackStopFX));
			SerializeField(s, nameof(diggingWrongFX));
			SerializeField(s, nameof(soundTimeBeforeStop));
			SerializeField(s, nameof(diggingHoldEnemyFX));
			SerializeField(s, nameof(soundTimeEnemyBeforeStop));
			SerializeField(s, nameof(diggingParticlesFX));
			SerializeField(s, nameof(fillingParticlesFX));
			SerializeField(s, nameof(BorderFill));
			SerializeField(s, nameof(Use_backGround));
			SerializeField(s, nameof(UseExtremity));
			SerializeField(s, nameof(OffsetExtremityIntact));
			SerializeField(s, nameof(OffsetExtremityDamaged));
			SerializeField(s, nameof(MergeCount));
			SerializeField(s, nameof(LumsShapeOffset));
			SerializeField(s, nameof(LumsRadius));
			SerializeField(s, nameof(LumsAnticipation));
			SerializeField(s, nameof(LumsCountMaxByChain));
		}
		public override uint? ClassCRC => 0xAC378D71;
	}
}

