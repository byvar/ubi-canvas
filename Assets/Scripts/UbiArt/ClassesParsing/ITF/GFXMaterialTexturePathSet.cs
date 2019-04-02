using System.Reflection;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class GFXMaterialTexturePathSet {
		public TextureCooked tex_diffuse;
		public TextureCooked tex_back_light;
		public TextureCooked tex_normal;
		public TextureCooked tex_separateAlpha;
		public TextureCooked tex_diffuse_2;
		public TextureCooked tex_back_light_2;
		public TextureCooked tex_anim_impostor;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				LoadTexture(nameof(tex_diffuse), diffuse);
				/*LoadTexture(nameof(tex_back_light), back_light);
				LoadTexture(nameof(tex_normal), normal);
				LoadTexture(nameof(tex_separateAlpha), separateAlpha);
				LoadTexture(nameof(tex_diffuse_2), diffuse_2);
				LoadTexture(nameof(tex_back_light_2), back_light_2);
				LoadTexture(nameof(tex_anim_impostor), anim_impostor);*/
			}
		}

		protected void LoadTexture(string fieldName, Path path) {
			MapLoader l = MapLoader.Loader;
			l.Load(path, (extS) => {
				FieldInfo f = GetType().GetField(fieldName);
				if (l.tex.ContainsKey(diffuse.stringID)) {
					f.SetValue(this, l.tex[diffuse.stringID]);
				} else {
					extS.Serialize(this, f);
					TextureCooked tex = (TextureCooked)f.GetValue(this);
					tex.atlas = l.uvAtlasManager.GetAtlasIfExists(path);
					l.tex[path.stringID] = tex;
					l.print("Read:" + extS.Position + " - Length:" + extS.Length + " - " + (extS.Position == extS.Length ? "good!" : "bad!"));
				}
			});
		}
	}
}
