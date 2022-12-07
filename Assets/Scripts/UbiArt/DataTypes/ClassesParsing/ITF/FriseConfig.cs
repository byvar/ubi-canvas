namespace UbiArt.ITF {
	public partial class FriseConfig {
		GenericFile<GameMaterial_Template> loaded_gameMaterial;
		GenericFile<GameMaterial_Template> loaded_gameMaterialExtremityStart;
		GenericFile<GameMaterial_Template> loaded_gameMaterialExtremityStop;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;

				l.LoadFile<GenericFile<GameMaterial_Template>>(gameMaterial, result => loaded_gameMaterial = result);
				l.LoadFile<GenericFile<GameMaterial_Template>>(gameMaterialExtremityStart, result => loaded_gameMaterialExtremityStart = result);
				l.LoadFile<GenericFile<GameMaterial_Template>>(gameMaterialExtremityStop, result => loaded_gameMaterialExtremityStop = result);

			}
		}
	}
}
