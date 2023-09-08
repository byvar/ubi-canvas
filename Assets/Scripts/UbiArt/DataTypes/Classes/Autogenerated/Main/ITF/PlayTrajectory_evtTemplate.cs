namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PlayTrajectory_evtTemplate : SequenceEventWithActor_Template {
		public float coeffOneCamera;
		public float coeffOneCameraOut;
		public ObjectPath ParentFriendlyName;
		public StringID ParentID;
		public string ParentBone;
		public bool RestoreInitialPos = true;
		public Trajectory_Template Keyframes;
		public int startFrameCameraBlend;
		public float coeffCameraIn = 1f;
		public float coeffCameraOut;
		public uint cameraMask = 0xFFFFFFFF;
		public BoolEventList Flip;
		public Spline Color;
		public Spline Alpha;
		public Spline FogColor;
		public Spline FogAlpha;
		public bool UseSequenceInitialPos;
		public bool MustUpdateChildrenPos;
		public float coeffTwoCamera;
		public float coeffTwoCameraOut;
		public float depthZ;
		public float actorInterpoDuration;
		public int actorInterpoSetFlipFromSpeed;
		public bool dynamicDeltaFogZ;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				RestoreInitialPos = s.Serialize<bool>(RestoreInitialPos, name: "RestoreInitialPos");
				Keyframes = s.SerializeObject<Trajectory_Template>(Keyframes, name: "Keyframes");
				startFrameCameraBlend = s.Serialize<int>(startFrameCameraBlend, name: "startFrameCameraBlend");
				coeffOneCamera = s.Serialize<float>(coeffOneCamera, name: "coeffOneCamera");
				coeffTwoCamera = s.Serialize<float>(coeffTwoCamera, name: "coeffTwoCamera");
				coeffOneCameraOut = s.Serialize<float>(coeffOneCameraOut, name: "coeffOneCameraOut");
				coeffTwoCameraOut = s.Serialize<float>(coeffTwoCameraOut, name: "coeffTwoCameraOut");
			} else if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					coeffOneCamera = s.Serialize<float>(coeffOneCamera, name: "coeffOneCamera");
					coeffOneCameraOut = s.Serialize<float>(coeffOneCameraOut, name: "coeffOneCameraOut");
				}
				ParentFriendlyName = s.SerializeObject<ObjectPath>(ParentFriendlyName, name: "ParentFriendlyName");
				ParentID = s.SerializeObject<StringID>(ParentID, name: "ParentID");
				ParentBone = s.Serialize<string>(ParentBone, name: "ParentBone");
				RestoreInitialPos = s.Serialize<bool>(RestoreInitialPos, name: "RestoreInitialPos");
				Keyframes = s.SerializeObject<Trajectory_Template>(Keyframes, name: "Keyframes");
				startFrameCameraBlend = s.Serialize<int>(startFrameCameraBlend, name: "startFrameCameraBlend");
				coeffCameraIn = s.Serialize<float>(coeffCameraIn, name: "coeffCameraIn");
				coeffCameraOut = s.Serialize<float>(coeffCameraOut, name: "coeffCameraOut");
				if (s.Settings.Platform == GamePlatform.Vita) {
					depthZ = -1f;
				} else {
					depthZ = s.Serialize<float>(depthZ, name: "depthZ");
					dynamicDeltaFogZ = s.Serialize<bool>(dynamicDeltaFogZ, name: "dynamicDeltaFogZ");
				}
				cameraMask = s.Serialize<uint>(cameraMask, name: "cameraMask");
				Flip = s.SerializeObject<BoolEventList>(Flip, name: "Flip");
				Color = s.SerializeObject<Spline>(Color, name: "Color");
				Alpha = s.SerializeObject<Spline>(Alpha, name: "Alpha");
				UseSequenceInitialPos = s.Serialize<bool>(UseSequenceInitialPos, name: "UseSequenceInitialPos");
			} else if (s.Settings.Game == Game.COL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					coeffOneCamera = s.Serialize<float>(coeffOneCamera, name: "coeffOneCamera");
					coeffOneCameraOut = s.Serialize<float>(coeffOneCameraOut, name: "coeffOneCameraOut");
				}
				ParentFriendlyName = s.SerializeObject<ObjectPath>(ParentFriendlyName, name: "ParentFriendlyName");
				ParentID = s.SerializeObject<StringID>(ParentID, name: "ParentID");
				ParentBone = s.Serialize<string>(ParentBone, name: "ParentBone");
				RestoreInitialPos = s.Serialize<bool>(RestoreInitialPos, name: "RestoreInitialPos", options: CSerializerObject.Options.BoolAsByte);
				Keyframes = s.SerializeObject<Trajectory_Template>(Keyframes, name: "Keyframes");
				startFrameCameraBlend = s.Serialize<int>(startFrameCameraBlend, name: "startFrameCameraBlend");
				actorInterpoDuration = s.Serialize<float>(actorInterpoDuration, name: "actorInterpoDuration");
				actorInterpoSetFlipFromSpeed = s.Serialize<int>(actorInterpoSetFlipFromSpeed, name: "actorInterpoSetFlipFromSpeed");
				coeffCameraIn = s.Serialize<float>(coeffCameraIn, name: "coeffCameraIn");
				coeffCameraOut = s.Serialize<float>(coeffCameraOut, name: "coeffCameraOut");
				depthZ = s.Serialize<float>(depthZ, name: "depthZ");
				dynamicDeltaFogZ = s.Serialize<bool>(dynamicDeltaFogZ, name: "dynamicDeltaFogZ", options: CSerializerObject.Options.BoolAsByte);
				cameraMask = s.Serialize<uint>(cameraMask, name: "cameraMask");
				Flip = s.SerializeObject<BoolEventList>(Flip, name: "Flip");
				Color = s.SerializeObject<Spline>(Color, name: "Color");
				Alpha = s.SerializeObject<Spline>(Alpha, name: "Alpha");
				UseSequenceInitialPos = s.Serialize<bool>(UseSequenceInitialPos, name: "UseSequenceInitialPos", options: CSerializerObject.Options.BoolAsByte);
			} else if (s.Settings.Game == Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					coeffOneCamera = s.Serialize<float>(coeffOneCamera, name: "coeffOneCamera");
					coeffOneCameraOut = s.Serialize<float>(coeffOneCameraOut, name: "coeffOneCameraOut");
				}
				ParentFriendlyName = s.SerializeObject<ObjectPath>(ParentFriendlyName, name: "ParentFriendlyName");
				ParentID = s.SerializeObject<StringID>(ParentID, name: "ParentID");
				ParentBone = s.Serialize<string>(ParentBone, name: "ParentBone");
				RestoreInitialPos = s.Serialize<bool>(RestoreInitialPos, name: "RestoreInitialPos");
				Keyframes = s.SerializeObject<Trajectory_Template>(Keyframes, name: "Keyframes");
				startFrameCameraBlend = s.Serialize<int>(startFrameCameraBlend, name: "startFrameCameraBlend");
				coeffCameraIn = s.Serialize<float>(coeffCameraIn, name: "coeffCameraIn");
				coeffCameraOut = s.Serialize<float>(coeffCameraOut, name: "coeffCameraOut");
				cameraMask = s.Serialize<uint>(cameraMask, name: "cameraMask");
				Flip = s.SerializeObject<BoolEventList>(Flip, name: "Flip");
				Color = s.SerializeObject<Spline>(Color, name: "Color");
				Alpha = s.SerializeObject<Spline>(Alpha, name: "Alpha");
				UseSequenceInitialPos = s.Serialize<bool>(UseSequenceInitialPos, name: "UseSequenceInitialPos");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					coeffOneCamera = s.Serialize<float>(coeffOneCamera, name: "coeffOneCamera");
					coeffOneCameraOut = s.Serialize<float>(coeffOneCameraOut, name: "coeffOneCameraOut");
				}
				ParentFriendlyName = s.SerializeObject<ObjectPath>(ParentFriendlyName, name: "ParentFriendlyName");
				ParentID = s.SerializeObject<StringID>(ParentID, name: "ParentID");
				ParentBone = s.Serialize<string>(ParentBone, name: "ParentBone");
				RestoreInitialPos = s.Serialize<bool>(RestoreInitialPos, name: "RestoreInitialPos");
				Keyframes = s.SerializeObject<Trajectory_Template>(Keyframes, name: "Keyframes");
				startFrameCameraBlend = s.Serialize<int>(startFrameCameraBlend, name: "startFrameCameraBlend");
				coeffCameraIn = s.Serialize<float>(coeffCameraIn, name: "coeffCameraIn");
				coeffCameraOut = s.Serialize<float>(coeffCameraOut, name: "coeffCameraOut");
				cameraMask = s.Serialize<uint>(cameraMask, name: "cameraMask");
				Flip = s.SerializeObject<BoolEventList>(Flip, name: "Flip");
				Color = s.SerializeObject<Spline>(Color, name: "Color");
				Alpha = s.SerializeObject<Spline>(Alpha, name: "Alpha");
				FogColor = s.SerializeObject<Spline>(FogColor, name: "FogColor");
				FogAlpha = s.SerializeObject<Spline>(FogAlpha, name: "FogAlpha");
				UseSequenceInitialPos = s.Serialize<bool>(UseSequenceInitialPos, name: "UseSequenceInitialPos");
				MustUpdateChildrenPos = s.Serialize<bool>(MustUpdateChildrenPos, name: "MustUpdateChildrenPos");
			}
		}
		public override uint? ClassCRC => 0xA1DA8606;
	}
}

