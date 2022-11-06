using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class DigRegionComponent_Template : ActorComponent_Template {
		public GFXMaterialSerializable MaterialDig;
		public GFXMaterialSerializable MaterialPlump;
		public GFXMaterialSerializable MaterialBorder;
		public float BorderHeight;
		public float BorderVisualOffset;
		public float BorderBig_TileCount;
		public float BorderSmall_TileCount;
		public GFXMaterialSerializable MaterialBackGround;
		public GFXMaterialSerializable MaterialFill;
		public GFXMaterialSerializable MaterialFillBorder;
		public Path GameMaterial;
		public StringID diggingHoldFX;
		public StringID diggingBackHoldFX;
		public StringID diggingBackStopFX;
		public StringID diggingWrongFX;
		public float soundTimeBeforeStop;
		public StringID diggingHoldEnemyFX;
		public float soundTimeEnemyBeforeStop;
		public StringID diggingParticlesFX;
		public StringID fillingParticlesFX;
		public Border BorderFill;
		public bool Use_backGround;
		public bool UseExtremity;
		public float OffsetExtremityIntact;
		public float OffsetExtremityDamaged;
		public uint MergeCount;
		public Vec2d LumsShapeOffset;
		public float LumsRadius;
		public float LumsAnticipation;
		public uint LumsCountMaxByChain;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				MaterialDig = s.SerializeObject<GFXMaterialSerializable>(MaterialDig, name: "MaterialDig");
				MaterialPlump = s.SerializeObject<GFXMaterialSerializable>(MaterialPlump, name: "MaterialPlump");
				MaterialBorder = s.SerializeObject<GFXMaterialSerializable>(MaterialBorder, name: "MaterialBorder");
				BorderHeight = s.Serialize<float>(BorderHeight, name: "BorderHeight");
				BorderVisualOffset = s.Serialize<float>(BorderVisualOffset, name: "BorderVisualOffset");
				BorderBig_TileCount = s.Serialize<float>(BorderBig_TileCount, name: "BorderBig_TileCount");
				BorderSmall_TileCount = s.Serialize<float>(BorderSmall_TileCount, name: "BorderSmall_TileCount");
			}
			MaterialBackGround = s.SerializeObject<GFXMaterialSerializable>(MaterialBackGround, name: "MaterialBackGround");
			MaterialFill = s.SerializeObject<GFXMaterialSerializable>(MaterialFill, name: "MaterialFill");
			MaterialFillBorder = s.SerializeObject<GFXMaterialSerializable>(MaterialFillBorder, name: "MaterialFillBorder");
			GameMaterial = s.SerializeObject<Path>(GameMaterial, name: "GameMaterial");
			diggingHoldFX = s.SerializeObject<StringID>(diggingHoldFX, name: "diggingHoldFX");
			diggingBackHoldFX = s.SerializeObject<StringID>(diggingBackHoldFX, name: "diggingBackHoldFX");
			diggingBackStopFX = s.SerializeObject<StringID>(diggingBackStopFX, name: "diggingBackStopFX");
			diggingWrongFX = s.SerializeObject<StringID>(diggingWrongFX, name: "diggingWrongFX");
			soundTimeBeforeStop = s.Serialize<float>(soundTimeBeforeStop, name: "soundTimeBeforeStop");
			diggingHoldEnemyFX = s.SerializeObject<StringID>(diggingHoldEnemyFX, name: "diggingHoldEnemyFX");
			soundTimeEnemyBeforeStop = s.Serialize<float>(soundTimeEnemyBeforeStop, name: "soundTimeEnemyBeforeStop");
			diggingParticlesFX = s.SerializeObject<StringID>(diggingParticlesFX, name: "diggingParticlesFX");
			fillingParticlesFX = s.SerializeObject<StringID>(fillingParticlesFX, name: "fillingParticlesFX");
			BorderFill = s.SerializeObject<Border>(BorderFill, name: "BorderFill");
			Use_backGround = s.Serialize<bool>(Use_backGround, name: "Use_backGround");
			UseExtremity = s.Serialize<bool>(UseExtremity, name: "UseExtremity");
			OffsetExtremityIntact = s.Serialize<float>(OffsetExtremityIntact, name: "OffsetExtremityIntact");
			OffsetExtremityDamaged = s.Serialize<float>(OffsetExtremityDamaged, name: "OffsetExtremityDamaged");
			MergeCount = s.Serialize<uint>(MergeCount, name: "MergeCount");
			LumsShapeOffset = s.SerializeObject<Vec2d>(LumsShapeOffset, name: "LumsShapeOffset");
			LumsRadius = s.Serialize<float>(LumsRadius, name: "LumsRadius");
			LumsAnticipation = s.Serialize<float>(LumsAnticipation, name: "LumsAnticipation");
			LumsCountMaxByChain = s.Serialize<uint>(LumsCountMaxByChain, name: "LumsCountMaxByChain");
		}
		public override uint? ClassCRC => 0xAC378D71;
	}
}

