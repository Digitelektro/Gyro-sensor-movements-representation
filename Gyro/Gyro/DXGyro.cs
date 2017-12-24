using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX;


namespace Gyro
{
    public partial class DXGyro : UserControl
    {
        #region Private Variables
        private Device device;
        private int _Pitch = 0;
        private int _Roll = 0;
        private Color _cubecolor = Color.White;
        private CustomVertex.PositionNormalColored[] verts;
        #endregion

        #region Properties
        /// <summary>
        /// Set cube pitch
        /// </summary>
        public int Pitch
        {
            get { return this._Pitch; }
            set
            {
                this._Pitch = value;
                DoDraw();
            }

        }
        /// <summary>
        /// Set cube Roll
        /// </summary>
        public int Roll
        {
            get { return this._Roll; }
            set
            {
                this._Roll = value;
                DoDraw();
            }

        }
        /// <summary>
        /// Set Cube color
        /// </summary>
        public Color CubeColor
        {
            get { return this._cubecolor; }
            set
            {
                this._cubecolor = value;
                verts = CreateCube();
                DoDraw();
            }

        }
        #endregion

        #region Constructor
        public DXGyro()
        {
            InitializeComponent();
            verts = CreateCube();
            PresentParameters pp = new PresentParameters();
            pp.PresentFlag = PresentFlag.LockableBackBuffer;
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            pp.BackBufferWidth = this.Width;
            pp.BackBufferHeight = this.Height;
            device = new Device(0, DeviceType.Hardware, this, CreateFlags.HardwareVertexProcessing, pp);
        }
        #endregion

        #region Functions
        protected void SetupCamera()
        {
            //Set my field-of-view (perspective) and position-direction.
            device.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4.0f, (float)this.Width / (float)this.Height, 1.0f, 100.0f);
            device.Transform.View = Matrix.LookAtLH(new Vector3(0, 0, 5.0F), new Vector3(), new Vector3(0, 1, 0));

            device.RenderState.Lighting = true;

            //My single light
            device.Lights[0].Type = LightType.Point;
            device.Lights[0].Position = new Vector3(0, 0, 10);
            device.Lights[0].Ambient = System.Drawing.Color.White;
            device.Lights[0].Attenuation0 = 0.8F;
            device.Lights[0].Attenuation1 = 0.02F;
            device.Lights[0].Range = 1000.0F;

            device.Lights[0].Enabled = true;
        }

        protected CustomVertex.PositionNormalColored[] CreateCube()
        {
            float X2 = 0.5f;
            float Y2 = 0.2f;
            float Z2 = 1.0f;

            CustomVertex.PositionNormalColored[] verts = new CustomVertex.PositionNormalColored[36];
            //Front face.
            verts[0] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, Z2), new Vector3(0, 0, 1), _cubecolor.ToArgb());
            verts[1] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, Z2), new Vector3(0, 0, 1), _cubecolor.ToArgb());
            verts[2] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, Z2), new Vector3(0, 0, 1), _cubecolor.ToArgb());
            verts[3] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, Z2), new Vector3(0, 0, 1), _cubecolor.ToArgb());
            verts[4] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, Z2), new Vector3(0, 0, 1), _cubecolor.ToArgb());
            verts[5] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, Z2), new Vector3(0, 0, 1), _cubecolor.ToArgb());

            //Back face.  This is facing away from the camera, so vertices should be clockwise order.
            verts[6] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, -Z2), new Vector3(0, 0, -1), _cubecolor.ToArgb());
            verts[7] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, -Z2), new Vector3(0, 0, -1), _cubecolor.ToArgb());
            verts[8] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, -Z2), new Vector3(0, 0, -1), _cubecolor.ToArgb());
            verts[9] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, -Z2), new Vector3(0, 0, -1), _cubecolor.ToArgb());
            verts[10] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, -Z2), new Vector3(0, 0, -1), _cubecolor.ToArgb());
            verts[11] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, -Z2), new Vector3(0, 0, -1), _cubecolor.ToArgb());

            //Top face.
            verts[12] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, Z2), new Vector3(0, 1, 0), _cubecolor.ToArgb());
            verts[13] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, -Z2), new Vector3(0, 1, 0), _cubecolor.ToArgb());
            verts[14] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, -Z2), new Vector3(0, 1, 0), _cubecolor.ToArgb());
            verts[15] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, Z2), new Vector3(0, 1, 0), _cubecolor.ToArgb());
            verts[16] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, Z2), new Vector3(0, 1, 0), _cubecolor.ToArgb());
            verts[17] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, -Z2), new Vector3(0, 1, 0), _cubecolor.ToArgb());

            //Bottom face. This is facing away from the camera, so vertices should be clockwise order.
            verts[18] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, Z2), new Vector3(0, -1, 0), _cubecolor.ToArgb());
            verts[19] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, -Z2), new Vector3(0, -1, 0), _cubecolor.ToArgb());
            verts[20] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, -Z2), new Vector3(0, -1, 0), _cubecolor.ToArgb());
            verts[21] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, Z2), new Vector3(0, -1, 0), _cubecolor.ToArgb());
            verts[22] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, -Z2), new Vector3(0, -1, 0), _cubecolor.ToArgb());
            verts[23] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, Z2), new Vector3(0, -1, 0), _cubecolor.ToArgb());

            //Left face.
            verts[24] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, Z2), new Vector3(-1, 0, 0), _cubecolor.ToArgb());
            verts[25] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, -Z2), new Vector3(-1, 0, 0), _cubecolor.ToArgb());
            verts[26] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, Z2), new Vector3(-1, 0, 0), _cubecolor.ToArgb());
            verts[27] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, -Z2), new Vector3(-1, 0, 0), _cubecolor.ToArgb());
            verts[28] = new CustomVertex.PositionNormalColored(new Vector3(-X2, -Y2, -Z2), new Vector3(-1, 0, 0), _cubecolor.ToArgb());
            verts[29] = new CustomVertex.PositionNormalColored(new Vector3(-X2, Y2, Z2), new Vector3(-1, 0, 0), _cubecolor.ToArgb());

            //Right face. This is facing away from the camera, so vertices should be clockwise order.
            verts[30] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, Z2), new Vector3(1, 0, 0), _cubecolor.ToArgb());
            verts[31] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, Z2), new Vector3(1, 0, 0), _cubecolor.ToArgb());
            verts[32] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, -Z2), new Vector3(1, 0, 0), _cubecolor.ToArgb());
            verts[33] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, -Z2), new Vector3(1, 0, 0), _cubecolor.ToArgb());
            verts[34] = new CustomVertex.PositionNormalColored(new Vector3(X2, Y2, Z2), new Vector3(1, 0, 0), _cubecolor.ToArgb());
            verts[35] = new CustomVertex.PositionNormalColored(new Vector3(X2, -Y2, -Z2), new Vector3(1, 0, 0), _cubecolor.ToArgb());

            return verts;
        }

        protected void DoDraw()
        {
            try
            {
                SetupCamera();
                device.Clear(ClearFlags.Target, Color.Black, 1, 0);
                device.BeginScene();
                device.VertexFormat = CustomVertex.PositionNormalColored.Format;
                device.Transform.World = Matrix.RotationYawPitchRoll(0, (float)_Pitch * (float)Math.PI / 180.0f, -(float)_Roll * (float)Math.PI / 180.0f);
                device.DrawUserPrimitives(PrimitiveType.TriangleList, 12, verts);
                device.EndScene();
                device.Present();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DoDraw();
        }
        #endregion






    }
}
