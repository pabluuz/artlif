singleton Material(teich_boden_mat)
{
   mapTo = "teich_boden";
   diffuseMap[0] = "art/2D/Terrain/Substances/Soil/Soil_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Soil/Soil_nm.dds";
   doubleSided = "1";
};

singleton Material(teich_wasser_mat)
{
   mapTo = "teich_wasser";
   diffuseMap[0] = "teich_wasser.dds";
   translucentBlendOp = "LerpAlpha";
   translucent = "1";
   pixelSpecular[0] = "1";
   specular[0] = "0.8 0.972549 0.996078 1";
   specularPower[0] = "8";
};
singleton Material(teich_rock_a_mat)
{
   mapTo = "teich_rock_a";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock/Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock/Rock_nm.dds";
   diffuseMap[2] = "art/2D/Terrain/Substances/Rock/Rock_hm.dds";
   doubleSided = "1";
   normal3DC="1";
};

singleton Material(wasserpflanze_a_mat)
{
   mapTo = "wasserpflanze_a";
   diffuseMap[0] = "art/Textures/GroundCover/SwampGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SwampGrassesAtlas_Normal.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   normal3DC="1";
};

singleton Material(teich_rock_b_mat)
{
   mapTo = "teich_rock_b";
   diffuseMap[0] = "art/2D/Terrain/Substances/Marble/Marble_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Marble/Marble_nm.dds";
   diffuseMap[2] = "art/2D/Terrain/Substances/Marble/Marble_hm.dds";
   doubleSided = "1";
   normal3DC="1";
};

singleton Material(teich_rock_c_mat)
{
   mapTo = "teich_rock_c";
   diffuseMap[0] = "art/2D/Terrain/Substances/Granite/Granite_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Granite/Granite_nm.dds";
   diffuseMap[2] = "art/2D/Terrain/Substances/Granite/Granite_hm.dds";
   doubleSided = "1";
   normal3DC="1";
};

singleton Material(fisch_mat)
{
   mapTo = "fisch";
   diffuseMap[0] = "fisch.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   normal3DC="1";
};

singleton Material(teich_lod_mat)
{
   mapTo = "teich_lod";
   diffuseMap[0] = "teich_lod3.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   normal3DC="1";
};