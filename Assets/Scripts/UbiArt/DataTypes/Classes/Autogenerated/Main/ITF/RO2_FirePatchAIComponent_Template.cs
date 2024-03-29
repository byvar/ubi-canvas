namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_FirePatchAIComponent_Template : GraphicComponent_Template {
		public float sidePatchLength = 1f;
		public float sidePatchWidth = 1f;
		public float spaceMinBetween2Start = 1f;
		public float spaceMaxBetween2Start = 1f;
		public float offsetMin;
		public float offsetMax;
		public float scaleMin = 1f;
		public float scaleMax = 2f;
		public uint modTileMin = 2;
		public uint modTileMax = 2;
		public float openSpeed = 10f;
		public uint startOpen;
		public uint endOpen;
		public uint startLoop;
		public uint endLoop;
		public uint startClose;
		public uint endClose;
		public uint smokeStartOpen;
		public uint smokeEndOpen;
		public uint smokeStartLoop;
		public uint smokeEndLoop;
		public uint smokeStartClose;
		public uint smokeEndClose;
		public bool useSmoke;
		public float smokeForwardOffset = 2f;
		public float smokeBackwardOffset;
		public GFXMaterialSerializable sideMaterial;
		public GFXMaterialSerializable smokeMaterial;
		public float tessellationLength = 0.1f;
		public uint faction;
		public float stimBezierLength = 2f;
		public float stimBezierWidth = 1f;
		public float distSafeHead;
		public float stimOffsetTail;
		public uint sideMode;
		public float zOffset;
		public StringID startMarker;
		public StringID stopMarker;
		public bool stopOnHitSuccessful;
		public bool stopDeployOnStop;
		public bool useOptimAABB;
		public bool registerToAIManager;
		public uint countHitHysteresisTrame = 60;
		public bool fireUseStim = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sidePatchLength = s.Serialize<float>(sidePatchLength, name: "sidePatchLength");
			sidePatchWidth = s.Serialize<float>(sidePatchWidth, name: "sidePatchWidth");
			spaceMinBetween2Start = s.Serialize<float>(spaceMinBetween2Start, name: "spaceMinBetween2Start");
			spaceMaxBetween2Start = s.Serialize<float>(spaceMaxBetween2Start, name: "spaceMaxBetween2Start");
			offsetMin = s.Serialize<float>(offsetMin, name: "offsetMin");
			offsetMax = s.Serialize<float>(offsetMax, name: "offsetMax");
			scaleMin = s.Serialize<float>(scaleMin, name: "scaleMin");
			scaleMax = s.Serialize<float>(scaleMax, name: "scaleMax");
			modTileMin = s.Serialize<uint>(modTileMin, name: "modTileMin");
			modTileMax = s.Serialize<uint>(modTileMax, name: "modTileMax");
			openSpeed = s.Serialize<float>(openSpeed, name: "openSpeed");
			startOpen = s.Serialize<uint>(startOpen, name: "startOpen");
			endOpen = s.Serialize<uint>(endOpen, name: "endOpen");
			startLoop = s.Serialize<uint>(startLoop, name: "startLoop");
			endLoop = s.Serialize<uint>(endLoop, name: "endLoop");
			startClose = s.Serialize<uint>(startClose, name: "startClose");
			endClose = s.Serialize<uint>(endClose, name: "endClose");
			smokeStartOpen = s.Serialize<uint>(smokeStartOpen, name: "smokeStartOpen");
			smokeEndOpen = s.Serialize<uint>(smokeEndOpen, name: "smokeEndOpen");
			smokeStartLoop = s.Serialize<uint>(smokeStartLoop, name: "smokeStartLoop");
			smokeEndLoop = s.Serialize<uint>(smokeEndLoop, name: "smokeEndLoop");
			smokeStartClose = s.Serialize<uint>(smokeStartClose, name: "smokeStartClose");
			smokeEndClose = s.Serialize<uint>(smokeEndClose, name: "smokeEndClose");
			useSmoke = s.Serialize<bool>(useSmoke, name: "useSmoke");
			smokeForwardOffset = s.Serialize<float>(smokeForwardOffset, name: "smokeForwardOffset");
			smokeBackwardOffset = s.Serialize<float>(smokeBackwardOffset, name: "smokeBackwardOffset");
			sideMaterial = s.SerializeObject<GFXMaterialSerializable>(sideMaterial, name: "sideMaterial");
			smokeMaterial = s.SerializeObject<GFXMaterialSerializable>(smokeMaterial, name: "smokeMaterial");
			tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			faction = s.Serialize<uint>(faction, name: "faction");
			stimBezierLength = s.Serialize<float>(stimBezierLength, name: "stimBezierLength");
			stimBezierWidth = s.Serialize<float>(stimBezierWidth, name: "stimBezierWidth");
			distSafeHead = s.Serialize<float>(distSafeHead, name: "distSafeHead");
			stimOffsetTail = s.Serialize<float>(stimOffsetTail, name: "stimOffsetTail");
			sideMode = s.Serialize<uint>(sideMode, name: "sideMode");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			startMarker = s.SerializeObject<StringID>(startMarker, name: "startMarker");
			stopMarker = s.SerializeObject<StringID>(stopMarker, name: "stopMarker");
			stopOnHitSuccessful = s.Serialize<bool>(stopOnHitSuccessful, name: "stopOnHitSuccessful");
			stopDeployOnStop = s.Serialize<bool>(stopDeployOnStop, name: "stopDeployOnStop");
			useOptimAABB = s.Serialize<bool>(useOptimAABB, name: "useOptimAABB");
			registerToAIManager = s.Serialize<bool>(registerToAIManager, name: "registerToAIManager");
			countHitHysteresisTrame = s.Serialize<uint>(countHitHysteresisTrame, name: "countHitHysteresisTrame");
			fireUseStim = s.Serialize<bool>(fireUseStim, name: "fireUseStim");
		}
		public override uint? ClassCRC => 0x7CB6F750;
	}
}

