namespace UbiArt.Animation {
	// See: ITF::AnimTrack::serialize
	// anm.ckd file
	public class AnimTrack : CSerializable {
		public const uint VersionLegends = 34;

		public uint version;
		public float length;
		public CListO<AnimTrackBML> bml;
		public CListO<AnimTrackBonePAS> bonePAS;
		public CListO<AnimTrackBoneZAL> boneZAL;
		public float multiplierA;
		public float multiplierP;
		public float multiplierS;
		public CListO<AnimTrackPolyline> polylines;
		public CListO<AnimTrackBonesList> bonesLists;
		public CListO<AnimTrackFrameEvents> frameEvents;
		public CListO<AnimTrackFrameSoundEvents> soundEvents;
		public CListO<Vec2d> vectors;
		public Vec2d vec0;
		public Vec2d vec1;
		public Vec2d vec2;
		public Vec2d vec3;
		public pair<StringID, Path> skeleton;
		public pair<StringID, CString> skeletonOrigins;
		public KeyArray<int> texturePathKeysOrigins;
		public CListO<pair<StringID, Path>> texturePaths;
		public CListO<pair<StringID, CString>> texturePathsOrigins;
		public uint bankId0;
		public uint bankId;
		public uint unk2;
		public ulong unk0Origins;
		public CListP<ulong> unk1Origins;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			version = s.Serialize<uint>(version, name: "version");
			length = s.Serialize<float>(length, name: "length");
			bml = s.SerializeObject<CListO<AnimTrackBML>>(bml, name: "BML");
			bonePAS = s.SerializeObject<CListO<AnimTrackBonePAS>>(bonePAS, name: "PAS");
			boneZAL = s.SerializeObject<CListO<AnimTrackBoneZAL>>(boneZAL, name: "ZAL");
			multiplierA = s.Serialize<float>(multiplierA, name: "multiplierA");
			multiplierP = s.Serialize<float>(multiplierP, name: "multiplierP");
			multiplierS = s.Serialize<float>(multiplierS, name: "multiplierS");
			polylines = s.SerializeObject<CListO<AnimTrackPolyline>>(polylines, name: "polylines");
			bonesLists = s.SerializeObject<CListO<AnimTrackBonesList>>(bonesLists, name: "bones");
			frameEvents = s.SerializeObject<CListO<AnimTrackFrameEvents>>(frameEvents, name: "frameEvents");
			soundEvents = s.SerializeObject<CListO<AnimTrackFrameSoundEvents>>(soundEvents, name: "soundEvents");
			vectors = s.SerializeObject<CListO<Vec2d>>(vectors, name: "vectors");
			vec0 = s.SerializeObject<Vec2d>(vec0, name: "vec0");
			vec1 = s.SerializeObject<Vec2d>(vec1, name: "vec1");
			vec2 = s.SerializeObject<Vec2d>(vec2, name: "vec2");
			vec3 = s.SerializeObject<Vec2d>(vec3, name: "vec3");
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				skeleton = s.SerializeObject<pair<StringID, Path>>(skeleton, name: "skeleton");
				texturePaths = s.SerializeObject<CListO<pair<StringID, Path>>>(texturePaths, name: "textures");
				if (s.Settings.game == Settings.Game.RL) {
					bankId0 = s.Serialize<uint>(bankId0, name: "bankId0");
				}
				bankId = s.Serialize<uint>(bankId, name: "bankId");
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			} else {
				skeletonOrigins = s.SerializeObject<pair<StringID, CString>>(skeletonOrigins, name: "skeleton");
				texturePathKeysOrigins = s.SerializeObject<KeyArray<int>>(texturePathKeysOrigins, name: "texturePathKeys");
				texturePathsOrigins = s.SerializeObject<CListO<pair<StringID, CString>>>(texturePathsOrigins, name: "textures");
				unk0Origins = s.Serialize<ulong>(unk0Origins, name: "unk0");
				unk1Origins = s.SerializeObject<CListP<ulong>>(unk1Origins, name: "unk1");
				unk2 = s.Serialize<uint>(unk2, name: "unk2");
			}
		}

		public AnimSkeleton skel;
		public TextureCooked[] texs;
		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			Loader l = s.Context.Loader;
			if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
				if (skeleton != null && skeleton.Item2 != null && IsFirstLoad) {
					l.LoadFile<AnimSkeleton>(skeleton.Item2, result => skel = result);
				}
				if (texturePaths != null) {
					texs = new TextureCooked[texturePaths.Count];
					for (int i = 0; i < texturePaths.Count; i++) {
						LoadTexture(l, i, texturePaths[i].Item2);
					}
				}
			} else {
				if (skeletonOrigins != null && skeletonOrigins.Item2 != null && IsFirstLoad) {
					l.LoadFile<AnimSkeleton>(new Path(skeletonOrigins.Item2.str), result => skel = result);
				}
				if (texturePathsOrigins != null) {
					texs = new TextureCooked[texturePathsOrigins.Count];
					for (int i = 0; i < texturePathsOrigins.Count; i++) {
						LoadTexture(l, i, new Path(texturePathsOrigins[i].Item2.str));
					}
				}
			}
		}

		protected void LoadTexture(Loader l, int index, Path path) {
			l.LoadTexture(path, tex => {
				texs[index] = tex;
			});
		}
		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Settings);
		}
		public void Reinit(Settings settings) {
			if (settings.game == Settings.Game.RL && version >= VersionLegends) {
				version = VersionLegends;
			}
		}

	}
}
