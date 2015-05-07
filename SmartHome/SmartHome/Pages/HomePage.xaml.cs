﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            //网关
            var tgr_W0103 = new TapGestureRecognizer();
            tgr_W0103.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了网关", "OK");
            };
            CU_W0103.GestureRecognizers.Add(tgr_W0103);

            //触摸开关
            var tgr_K0203 = new TapGestureRecognizer();
            tgr_K0203.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了触摸开关", "OK");
            };
            CU_K0203.GestureRecognizers.Add(tgr_K0203);

            //门窗磁
            var tgr_A0501 = new TapGestureRecognizer();
            tgr_A0501.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了门窗磁", "OK");
            };
            CU_A0501.GestureRecognizers.Add(tgr_A0501);

            //红外感应器
            var tgr_A0541 = new TapGestureRecognizer();
            tgr_A0541.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了红外感应器", "OK");
            };
            CU_A0541.GestureRecognizers.Add(tgr_A0541);

            //调色控制器
            var tgr_C0611 = new TapGestureRecognizer();
            tgr_C0611.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了调色控制器", "OK");
            };
            CU_C0611.GestureRecognizers.Add(tgr_C0611);

            //智能继电器
            var tgr_K0221 = new TapGestureRecognizer();
            tgr_K0221.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了智能继电器", "OK");
            };
            CU_K0221.GestureRecognizers.Add(tgr_K0221);

        }
    }
}
