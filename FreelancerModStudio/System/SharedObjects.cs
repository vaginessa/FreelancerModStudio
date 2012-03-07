﻿using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixEngine;
using HelixEngine.Meshes;

namespace FreelancerModStudio.SystemPresenter
{
    public enum ContentType
    {
        None,
        LightSource,
        Sun,
        Planet,
        Station,
        Satellite,
        Construct,
        Depot,
        Ship,
        WeaponsPlatform,
        DockingRing,
        JumpHole,
        JumpGate,
        TradeLane,
        Zone,
        System
    }

    public static class SharedMaterials
    {
        public static Material LightSource = MaterialHelper.CreateEmissiveMaterial(Color.FromRgb(120, 120, 0));
        public static Material Sun = MaterialHelper.CreateMaterial(Brushes.Orange);
        public static Material Planet = MaterialHelper.CreateMaterial(Color.FromRgb(0, 60, 120));
        public static Material Station = MaterialHelper.CreateMaterial(Brushes.OrangeRed);
        public static Material Satellite = MaterialHelper.CreateMaterial(Brushes.BlueViolet);
        public static Material Construct = MaterialHelper.CreateMaterial(Brushes.Fuchsia);
        public static Material Depot = MaterialHelper.CreateMaterial(Brushes.SlateGray);
        public static Material Ship = MaterialHelper.CreateMaterial(Brushes.Gold);
        public static Material WeaponsPlatform = MaterialHelper.CreateMaterial(Brushes.BurlyWood);
        public static Material TradeLane = MaterialHelper.CreateMaterial(Brushes.Cyan);
        public static Material JumpHoleAndGate = MaterialHelper.CreateMaterial(Brushes.DarkGreen);
        public static Material DockingRing = MaterialHelper.CreateMaterial(Brushes.Firebrick);
        public static Material CmpModel = MaterialHelper.CreateMaterial(Brushes.SlateGray);
        public static Material Zone = MaterialHelper.CreateEmissiveMaterial(Color.FromRgb(30, 30, 30));
        public static Material ZonePathTrade = MaterialHelper.CreateEmissiveMaterial(Color.FromRgb(10, 15, 30));
        public static Material ZoneVignette = MaterialHelper.CreateEmissiveMaterial(Color.FromRgb(0, 30, 15));
        public static Material ZoneExclusion = MaterialHelper.CreateEmissiveMaterial(Color.FromRgb(30, 15, 0));
        public static Material System = MaterialHelper.CreateMaterial(Brushes.LightYellow);

        public static Color ConnectionJumphole = Colors.OrangeRed;
        public static Color ConnectionJumpgate = Colors.SlateGray;
        public static Color ConnectionBoth = Colors.Snow;
        public static Color ConnectionNone = Colors.Black;
    }

    public static class SharedMeshes
    {
        public static MeshGeometry3D Sphere = GetMesh(new SphereMesh
        {
            Slices = 18,
            Stacks = 9
        });

        public static MeshGeometry3D Box = GetMesh(new BoxMesh());

        public static MeshGeometry3D BoxTradeLane = GetMesh(new BoxMesh
        {
            Height = 0.3,
        });

        public static MeshGeometry3D Cylinder = GetMesh(new CylinderMesh
        {
            Slices = 18,
        });

        public static MeshGeometry3D CylinderRing = GetMesh(new CylinderMesh
        {
            Radius = 0.5,
            Length = 0.25,
            Slices = 12,
        });

        public static MeshGeometry3D Pyramid = GetMesh(new PyramidMesh());

        public static MeshGeometry3D Octahedron = GetMesh(new OctahedronMesh());

        public static MeshGeometry3D Surface = GetMesh(new SurfaceMesh
        {
            Width = 2
        });

        static MeshGeometry3D GetMesh(MeshGeneratorBase mesh)
        {
            MeshGeometry3D geometry = mesh.Geometry;
            geometry.Freeze();
            return geometry;
        }
    }

    public static class SharedGeometries
    {
        public static GeometryModel3D LightSource =
            GetGeometry(SharedMeshes.Octahedron, SharedMaterials.LightSource);

        public static GeometryModel3D Sun =
            GetGeometry(SharedMeshes.Sphere, SharedMaterials.Sun);

        public static GeometryModel3D Planet =
            GetGeometry(SharedMeshes.Sphere, SharedMaterials.Planet);

        public static GeometryModel3D Station =
            GetGeometry(SharedMeshes.Box, SharedMaterials.Station);

        public static GeometryModel3D Ship =
            GetGeometry(SharedMeshes.Pyramid, SharedMaterials.Ship);

        public static GeometryModel3D WeaponsPlatform =
            GetGeometry(SharedMeshes.Box, SharedMaterials.WeaponsPlatform);

        public static GeometryModel3D TradeLane =
            GetGeometry(SharedMeshes.BoxTradeLane, SharedMaterials.TradeLane);

        public static GeometryModel3D JumpHole =
            GetGeometry(SharedMeshes.CylinderRing, SharedMaterials.JumpHoleAndGate);

        public static GeometryModel3D JumpGate =
            GetGeometry(SharedMeshes.Pyramid, SharedMaterials.JumpHoleAndGate);

        public static GeometryModel3D DockingRing =
            GetGeometry(SharedMeshes.CylinderRing, SharedMaterials.DockingRing);

        public static GeometryModel3D Satellite =
            GetGeometry(SharedMeshes.Box, SharedMaterials.Satellite);

        public static GeometryModel3D Construct =
            GetGeometry(SharedMeshes.Box, SharedMaterials.Construct);

        public static GeometryModel3D Depot =
            GetGeometry(SharedMeshes.Box, SharedMaterials.Depot);

        public static GeometryModel3D ZoneBox =
            GetGeometry(SharedMeshes.Box, SharedMaterials.Zone);

        public static GeometryModel3D ZoneSphere =
            GetGeometry(SharedMeshes.Sphere, SharedMaterials.Zone);

        public static GeometryModel3D ZoneCylinder =
            GetGeometry(SharedMeshes.Cylinder, SharedMaterials.Zone);

        public static GeometryModel3D ZoneRing =
            GetGeometry(SharedMeshes.Cylinder, SharedMaterials.Zone);

        public static GeometryModel3D ZonePathPatrol =
            GetGeometry(SharedMeshes.Surface, SharedMaterials.Zone);

        public static GeometryModel3D ZonePathTrade =
            GetGeometry(SharedMeshes.Surface, SharedMaterials.ZonePathTrade);

        public static GeometryModel3D ZoneVignette =
            GetGeometry(SharedMeshes.Sphere, SharedMaterials.ZoneVignette);

        public static GeometryModel3D ZoneExclusionBox =
            GetGeometry(SharedMeshes.Box, SharedMaterials.ZoneExclusion);

        public static GeometryModel3D ZoneExclusionSphere =
            GetGeometry(SharedMeshes.Sphere, SharedMaterials.ZoneExclusion);

        public static GeometryModel3D ZoneExclusionCylinder =
            GetGeometry(SharedMeshes.Cylinder, SharedMaterials.ZoneExclusion);

        public static GeometryModel3D ZoneExclusionRing =
            GetGeometry(SharedMeshes.Cylinder, SharedMaterials.ZoneExclusion);

        public static GeometryModel3D System =
            GetGeometry(SharedMeshes.Sphere, SharedMaterials.System);

        public static GeometryModel3D GetGeometry(Geometry3D geometry, Material material)
        {
            GeometryModel3D model = new GeometryModel3D(geometry, material);
            model.Freeze();
            return model;
        }
    }
}
