singleton Material(water_diff_a_mat)
{
   mapTo = "water_diff_a";
   diffuseMap[0] = "art/Textures/TextureLib/glass_diff.dds";
   diffuseMap[2] = "art/Textures/TextureLib/glass_spec.dds";
   specularScale = "0.01";
   doubleSided = "1";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
   alphaTest = "1";
   doNotZWrite = "1";
};