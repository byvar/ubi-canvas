
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class UnityAnimMeshVertex : MonoBehaviour {

	public class AnimationTrack {
		public StringID ID { get; set; }
		public string Name { get; set; }
		public SingleAnimData Data { get; set; }
		public int Index { get; set; }
		
		public uint PatchesCount { get; set; }
	}
	public class Patch {
		public GameObject Object { get; set; }
		public MeshRenderer Renderer { get; set; }
		public MeshFilter Filter { get; set; }
		public Mesh Mesh { get; set; }
	}
	public AnimMeshVertexComponent AnimMeshVertexComponent { get; set; }
	public AnimMeshVertexComponent_Template AnimMeshVertexComponentTemplate { get; set; }
	public AnimMeshVertex AMV => AnimMeshVertexComponentTemplate.amv;
	public Patch[] Patches { get; set; }

	public AnimationTrack Animation {
		get {
			if (anims != null && animIndex >= 0 && animIndex < anims.Length) {
				return anims[animIndex];
			}
			return null;
		}
	}
	public int animIndex = -1;
	public int currentPatchFrame = -1;
	public AnimationTrack[] anims;
	public bool playAnimation = true;
	public float animationSpeed = 30f;
	public int zValue = 0;
	bool loaded = false;

	public float currentFrame = 0;

	public void Start() {
	}
	public void Init() {
		Context l = Controller.MainContext;
		if (animIndex >= 0) {
			currentFrame = 0;
			currentPatchFrame = -1;
			InitAnimation();
			UpdateAnimation();
		}
		loaded = true;
	}

	public void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished && loaded && Animation != null) {
			if(playAnimation) currentFrame += Time.deltaTime * animationSpeed;
			UpdateAnimation();
		}
	}

	void InitAnimation() {
		if (Animation.PatchesCount == 0) {
			Animation.PatchesCount = AMV.frameMeshInfo[Animation.Index].Max(f => f.patchesCount);
		}
		if (Patches == null || Animation.PatchesCount != Patches.Length) {
			if (Patches != null) {
				foreach (var patch in Patches) {
					GameObject.Destroy(patch.Object);
				}
			}
			Patches = new Patch[Animation.PatchesCount];
			for (int i = 0; i < Patches.Length; i++) {
				var gao = AnimMeshVertexComponent.CreatePatch(gameObject, i, out MeshRenderer renderer, out Mesh mesh, out MeshFilter filter);
				Patches[i] = new Patch() {
					Object = gao,
					Mesh = mesh,
					Renderer = renderer,
					Filter = filter
				};
			}
		}
		transform.localPosition = Animation?.Data?.pos?.GetUnityVector(invertZ: true) ?? Vector3.zero;
		transform.localRotation = Animation?.Data?.angle?.GetUnityQuaternion() ?? Quaternion.identity;
		var scale = Vector3.one;
		if (Animation.Data != null) {
			if(Animation.Data.scale != null) scale = new Vector3(Animation.Data.scale.x, Animation.Data.scale.y, 1f);
			if(Animation.Data.flip) scale = new Vector3(-scale.x, scale.y, scale.z);
		}
	}

	void UpdateAnimation() {
		if (loaded && Animation != null) {
			var frames = AMV.frameMeshInfo[Animation.Index];
			var framesCount = frames.Count;
			if (framesCount == 0) {
				currentFrame = 0;
			} else if (currentFrame >= framesCount) {
				currentFrame %= framesCount;
			}
			var newPatchFrame = Mathf.FloorToInt(currentFrame);
			if (newPatchFrame != currentPatchFrame) {
				currentPatchFrame = newPatchFrame;
				var patchInfo = frames[currentPatchFrame];
				int patchIndex = (int)patchInfo.patchIndex;
				int patchesCount = (int)patchInfo.patchesCount;

				for (int i = 0; i < patchesCount; i++) {
					var patch = AMV.patches[patchIndex + i];
					var points = patch.points;

					Patches[i].Mesh.vertices = points.Select(p => new Vector3(p.x, p.y, 0f)).ToArray();
					Patches[i].Mesh.uv = points.Select((p, j) => AMV.uvs[patch.uvsIndex + j].GetUnityVector()).ToArray();
					//Patches[i].Filter.sharedMesh = Patches[i].Mesh;

					AnimMeshVertexComponent.SetColor(new UnityEngine.Color(1f, 1f, 1f, patch.alpha1 / 255f), Patches[i].Renderer);

					var obj = Patches[i].Object;
					if (!obj.activeSelf) obj.SetActive(true);
				}
				for (int i = patchesCount; i < Patches.Length; i++) {
					var obj = Patches[i].Object;
					if (obj.activeSelf) obj.SetActive(false);
				}
			}

			// Configure Z for all patches
			ZListManager zman = Controller.Obj.zListManager;
			for (int i = 0; i < Patches.Length; i++) {
				var ren = Patches[i].Renderer;
				if (!Patches[i].Object.activeSelf) {
					if (zman.zDict.ContainsKey(ren)) {
						zman.zDict.Remove(ren);
					}
				}
				zman.zDict[ren] = transform.position.z - (i / (float)Patches.Length) / 10000f;

			}

		}
	}
}