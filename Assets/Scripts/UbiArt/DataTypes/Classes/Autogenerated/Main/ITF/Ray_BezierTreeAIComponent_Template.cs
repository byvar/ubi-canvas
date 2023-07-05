namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BezierTreeAIComponent_Template : GraphicComponent_Template {
		public int lockFirstNode;
		public int lockLastNodeScale;
		public StringID attachBone;
		public Path gameMaterial;
		public PolylineMode polylineMode;
		public float polylineBeginLength;
		public float polylineEndLength;
		public float polylineBeginWidth;
		public float polylineMidWidth;
		public float polylineEndWidth;
		public float polylineStartOffset;
		public float polylineEndOffset;
		public float polylineTessellationLength;
		public BezierCurveRenderer_Template bezierRenderer;
		public uint mainSpriteIndex;
		public uint startSpriteIndex;
		public float startSpriteLength;
		public uint endSpriteIndex;
		public float endSpriteLength;
		public int uvStretch;
		public int uvAttachToHead;
		public float uvScrollSpeed;
		public TweenInterpreter_Template tweenInterpreter;
		public Path headActor;
		public float headAttachOffset;
		public CListO<Spawnable> spawnables;
		public StringID fx;
		public Ray_PlatformTreeComponent_Template ai;
		public int polylineDisableOnTransition;

		public int int__56;
		public int int__57;
		public float float__58;
		public float float__59;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);

			lockFirstNode = s.Serialize<int>(lockFirstNode, name: "lockFirstNode");
			lockLastNodeScale = s.Serialize<int>(lockLastNodeScale, name: "lockLastNodeScale");
			attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			polylineMode = s.Serialize<PolylineMode>(polylineMode, name: "polylineMode");
			polylineBeginLength = s.Serialize<float>(polylineBeginLength, name: "polylineBeginLength");
			polylineEndLength = s.Serialize<float>(polylineEndLength, name: "polylineEndLength");
			polylineBeginWidth = s.Serialize<float>(polylineBeginWidth, name: "polylineBeginWidth");
			polylineMidWidth = s.Serialize<float>(polylineMidWidth, name: "polylineMidWidth");
			polylineEndWidth = s.Serialize<float>(polylineEndWidth, name: "polylineEndWidth");
			polylineStartOffset = s.Serialize<float>(polylineStartOffset, name: "polylineStartOffset");
			polylineEndOffset = s.Serialize<float>(polylineEndOffset, name: "polylineEndOffset");
			polylineTessellationLength = s.Serialize<float>(polylineTessellationLength, name: "polylineTessellationLength");
			bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
			mainSpriteIndex = s.Serialize<uint>(mainSpriteIndex, name: "mainSpriteIndex");
			startSpriteIndex = s.Serialize<uint>(startSpriteIndex, name: "startSpriteIndex");
			startSpriteLength = s.Serialize<float>(startSpriteLength, name: "startSpriteLength");
			endSpriteIndex = s.Serialize<uint>(endSpriteIndex, name: "endSpriteIndex");
			endSpriteLength = s.Serialize<float>(endSpriteLength, name: "endSpriteLength");
			uvStretch = s.Serialize<int>(uvStretch, name: "uvStretch");
			uvAttachToHead = s.Serialize<int>(uvAttachToHead, name: "uvAttachToHead");
			uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
			tweenInterpreter = s.SerializeObject<TweenInterpreter_Template>(tweenInterpreter, name: "tweenInterpreter");
			headActor = s.SerializeObject<Path>(headActor, name: "headActor");
			headAttachOffset = s.Serialize<float>(headAttachOffset, name: "headAttachOffset");
			spawnables = s.SerializeObject<CListO<Spawnable>>(spawnables, name: "spawnables");
			fx = s.SerializeObject<StringID>(fx, name: "fx");
			ai = s.SerializeObject<Ray_PlatformTreeComponent_Template>(ai, name: "ai");
			polylineDisableOnTransition = s.Serialize<int>(polylineDisableOnTransition, name: "polylineDisableOnTransition");

			if (s.Settings.game == Settings.Game.RFR) {
				int__56 = s.Serialize<int>(int__56, name: "int__56");
				int__57 = s.Serialize<int>(int__57, name: "int__57");
				float__58 = s.Serialize<float>(float__58, name: "float__58");
				float__59 = s.Serialize<float>(float__59, name: "float__59");
			}
		}
		public enum PolylineMode {
			[Serialize("PolylineMode_None"       )] None = 0,
			[Serialize("PolylineMode_Left"       )] Left = 1,
			[Serialize("PolylineMode_Right"      )] Right = 2,
			[Serialize("PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public override uint? ClassCRC => 0x4CAD7A22;
	}
}

