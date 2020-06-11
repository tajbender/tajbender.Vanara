﻿using System;
using System.Runtime.InteropServices;

namespace Vanara.PInvoke
{
	public static partial class Shell32
	{
		/// <summary>The edge which should be adjacent.</summary>
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NF:shobjidl_core.IApplicationDesignModeSettings2.SetAdjacentDisplayEdges")]
		[Flags]
		public enum ADJACENT_DISPLAY_EDGES
		{
			/// <summary>The widow will not be adjacent to either edge.</summary>
			ADE_NONE = 0,

			/// <summary>the left edge of the window will be adjacent.</summary>
			ADE_LEFT = 0x1,

			/// <summary>The right edge of the window will be adjacent.</summary>
			ADE_RIGHT = 0x2
		}

		/// <summary>The desired minimum width of the application design mode window.</summary>
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NF:shobjidl_core.IApplicationDesignModeSettings2.SetApplicationViewMinWidth")]
		public enum APPLICATION_VIEW_MIN_WIDTH
		{
			/// <summary>Uses the default minimum width.</summary>
			AVMW_DEFAULT = 0,

			/// <summary>Sets the minimum width at 320 pixels.</summary>
			AVMW_320 = 1,

			/// <summary>Sets the minimum width at 500 pixels.</summary>
			AVMW_500 = 2
		}

		/// <summary>
		/// Defines the set of display orientation modes for a window (app view). Used by
		/// IApplicationDesignModeSettings2::GetApplicationViewOrientation and IApplicationDesignModeSettings2::SetApplicationViewOrientation.
		/// </summary>
		// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/ne-shobjidl_core-application_view_orientation typedef enum
		// APPLICATION_VIEW_ORIENTATION { AVO_LANDSCAPE, AVO_PORTRAIT } ;
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NE:shobjidl_core.APPLICATION_VIEW_ORIENTATION")]
		public enum APPLICATION_VIEW_ORIENTATION
		{
			/// <summary>The window is in landscape orientation, with the display width greater than the height.</summary>
			AVO_LANDSCAPE = 0,

			/// <summary>The window is in portrait orientation, with the display height greater than the width.</summary>
			AVO_PORTRAIT = (AVO_LANDSCAPE + 1)
		}

		/// <summary>
		/// Indicates the current view state of a Windows Store app. Used by IApplicationDesignModeSettings::SetApplicationViewState and IApplicationDesignModeSettings::IsApplicationViewStateSupported.
		/// </summary>
		// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/ne-shobjidl_core-application_view_state typedef enum
		// APPLICATION_VIEW_STATE { AVS_FULLSCREEN_LANDSCAPE, AVS_FILLED, AVS_SNAPPED, AVS_FULLSCREEN_PORTRAIT } ;
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NE:shobjidl_core.APPLICATION_VIEW_STATE")]
		public enum APPLICATION_VIEW_STATE
		{
			/// <summary>The current app's view is full-screen (has no snapped app adjacent to it), and is in landscape orientation.</summary>
			AVS_FULLSCREEN_LANDSCAPE,

			/// <summary>
			/// The current app's view has been reduced to a partial screen view as the result of another app snapping (being docked at one
			/// side of the screen in a narrow view).
			/// </summary>
			AVS_FILLED,

			/// <summary>The current app's view has been snapped (docked at one side of the screen in a narrow view).</summary>
			AVS_SNAPPED,

			/// <summary>The current app's view is full-screen (has no snapped app adjacent to it), and is in portrait orientation.</summary>
			AVS_FULLSCREEN_PORTRAIT,
		}

		/// <summary>
		/// Indicates a spoofed device scale factor, as a percent. Used by IApplicationDesignModeSettings::SetApplicationViewState and IApplicationDesignModeSettings::IsApplicationViewStateSupported
		/// </summary>
		// https://docs.microsoft.com/en-us/windows/win32/api/shtypes/ne-shtypes-device_scale_factor typedef enum DEVICE_SCALE_FACTOR {
		// DEVICE_SCALE_FACTOR_INVALID, SCALE_100_PERCENT, SCALE_120_PERCENT, SCALE_125_PERCENT, SCALE_140_PERCENT, SCALE_150_PERCENT,
		// SCALE_160_PERCENT, SCALE_175_PERCENT, SCALE_180_PERCENT, SCALE_200_PERCENT, SCALE_225_PERCENT, SCALE_250_PERCENT,
		// SCALE_300_PERCENT, SCALE_350_PERCENT, SCALE_400_PERCENT, SCALE_450_PERCENT, SCALE_500_PERCENT } ;
		[PInvokeData("shtypes.h", MSDNShortId = "NE:shtypes.DEVICE_SCALE_FACTOR")]
		public enum DEVICE_SCALE_FACTOR
		{
			/// <summary/>
			DEVICE_SCALE_FACTOR_INVALID = 0,

			/// <summary>100%. The scale factor for the device is 1x.</summary>
			SCALE_100_PERCENT = 100,

			/// <summary>120%. The scale factor for the device is 1.2x.</summary>
			SCALE_120_PERCENT = 120,

			/// <summary/>
			SCALE_125_PERCENT = 125,

			/// <summary>140%. The scale factor for the device is 1.4x.</summary>
			SCALE_140_PERCENT = 140,

			/// <summary>150%. The scale factor for the device is 1.5x.</summary>
			SCALE_150_PERCENT = 150,

			/// <summary>160%. The scale factor for the device is 1.6x.</summary>
			SCALE_160_PERCENT = 160,

			/// <summary/>
			SCALE_175_PERCENT = 175,

			/// <summary>180%. The scale factor for the device is 1.8x.</summary>
			SCALE_180_PERCENT = 180,

			/// <summary/>
			SCALE_200_PERCENT = 200,

			/// <summary>225%. The scale factor for the device is 2.25x.</summary>
			SCALE_225_PERCENT = 225,

			/// <summary/>
			SCALE_250_PERCENT = 250,

			/// <summary/>
			SCALE_300_PERCENT = 300,

			/// <summary/>
			SCALE_350_PERCENT = 350,

			/// <summary/>
			SCALE_400_PERCENT = 400,

			/// <summary/>
			SCALE_450_PERCENT = 450,

			/// <summary/>
			SCALE_500_PERCENT = 500,
		}

		/// <summary>Indicates the input type that generated the spoofed edge gesture.</summary>
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NF:shobjidl_core.IApplicationDesignModeSettings.TriggerEdgeGesture")]
		public enum EDGE_GESTURE_KIND
		{
			/// <summary>The edge gesture event was generated by a swipe on a touch-enabled screen.</summary>
			EGK_TOUCH = 0,

			/// <summary>The edge gesture event was generated by the Win+Z key sequence on the keyboard.</summary>
			EGK_KEYBOARD = (EGK_TOUCH + 1),

			/// <summary>The edge gesture event was generated by a right mouse click.</summary>
			EGK_MOUSE = (EGK_KEYBOARD + 1)
		}

		/// <summary>The native orientation of the display to emulate.</summary>
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NF:shobjidl_core.IApplicationDesignModeSettings2.SetNativeDisplayOrientation")]
		public enum NATIVE_DISPLAY_ORIENTATION
		{
			/// <summary>Landscape orientation, with the display width greater than the height.</summary>
			NDO_LANDSCAPE = 0,

			/// <summary>Portrait orientation, with the display height greater than the width.</summary>
			NDO_PORTRAIT = (NDO_LANDSCAPE + 1)
		}

		/// <summary>
		/// Enables development tool applications to dynamically spoof system and user states, such as native display resolution, device
		/// scale factor, and application view state, for the purpose of testing Windows Store apps running in design mode for a wide range
		/// of form factors without the need for the actual hardware. Also enables testing of changes in normally user-controlled state to
		/// test Windows Store apps under a variety of scenarios.
		/// </summary>
		/// <remarks>
		/// <para>This interface is acquired by cocreating CLSID_ApplicationDesignModeSettings.</para>
		/// <para>Users will normally follow a usage pattern similar to the following:</para>
		/// <list type="number">
		/// <item>
		/// <term>
		/// Call CoCreateInstance with CLSID_ApplicationDesignModeSettings to create the application design mode settings object on a thread
		/// in the Windows Store app process.
		/// </term>
		/// </item>
		/// <item>
		/// <term>Call QueryInterface on the application design mode settings object to obtain an IInitializeWithWindow object.</term>
		/// </item>
		/// <item>
		/// <term>
		/// Call the Initialize method of the IInitializeWithWindow object, passing in the HWND for the proxy core window. This must be done
		/// before any "set" methods are called and will only succeed once per process.
		/// </term>
		/// </item>
		/// <item>
		/// <term>
		/// Call QueryInterface for <c>IApplicationDesignModeSettings</c> and spoof the necessary test state by calling its appropriate
		/// methods (SetNativeDisplaySize, SetScaleFactor, etc.). These methods will trigger the appropriate Windows Runtime events to fire
		/// for the Windows Store app.
		/// </term>
		/// </item>
		/// <item>
		/// <term>
		/// Call the ComputeApplicationSize method to determine the proper size for the app, based on the currently spoofed state. All
		/// layout "set" methods must have already been called or this call will fail. The developer tool application is responsible for
		/// positioning and sizing the app windows, when appropriate.
		/// </term>
		/// </item>
		/// </list>
		/// <para>When to implement</para>
		/// <para>Do not implement this interface; the implementation is supplied with Windows.</para>
		/// <para>When to use</para>
		/// <para>Use the methods of this interface to test your Windows Store app under various spoofed configurations and scenarios.</para>
		/// <para>Examples</para>
		/// <para>This example shows the methods of this interface in use.</para>
		/// </remarks>
		// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationdesignmodesettings
		[PInvokeData("shobjidl_core.h", MSDNShortId = "NN:shobjidl_core.IApplicationDesignModeSettings")]
		[ComImport, Guid("2A3DEE9A-E31D-46D6-8508-BCC597DB3557"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(ApplicationDesignModeSettings))]
		public interface IApplicationDesignModeSettings
		{
			/// <summary>
			/// <para>Sets a spoofed native display size to be used for a Windows Store app running in design mode.</para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para><c>SetNativeDisplaySize</c> must be called before calling ComputeApplicationSize.</para>
			/// </summary>
			/// <param name="nativeDisplaySizePixels">
			/// The native size of the display to spoof, as a SIZE structure. The specified size will be normalized to a landscape
			/// orientation. To spoof orientation, see SetApplicationViewState.
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setnativedisplaysize
			// HRESULT SetNativeDisplaySize( SIZE nativeDisplaySizePixels );
			void SetNativeDisplaySize(SIZE nativeDisplaySizePixels);

			/// <summary>
			/// <para>Sets a spoofed device scale factor to be used for a Windows Store app running in design mode.</para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para><c>SetScaleFactor</c> must be called before calling ComputeApplicationSize.</para>
			/// </summary>
			/// <param name="scaleFactor">One of the DEVICE_SCALE_FACTOR enumeration values that indicates the device scale factor to spoof.</param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setscalefactor
			// HRESULT SetScaleFactor( DEVICE_SCALE_FACTOR scaleFactor );
			void SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor);

			/// <summary>
			/// <para>
			/// Sets a spoofed application view state (full-screen landscape, full-screen portrait, filled, or snapped) to be used for a
			/// Windows Store app running in design mode.
			/// </para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para><c>SetApplicationViewState</c> must be called before calling ComputeApplicationSize.</para>
			/// </summary>
			/// <param name="viewState">
			/// One of the APPLICATION_VIEW_STATE enumeration values that indicates the application view state to spoof.
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setapplicationviewstate
			// HRESULT SetApplicationViewState( APPLICATION_VIEW_STATE viewState );
			void SetApplicationViewState(APPLICATION_VIEW_STATE viewState);

			/// <summary>
			/// <para>Gets the size of the Windows Store app, based on the current set of spoofed settings.</para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para>In addition, each of these methods must be called before calling <c>ComputeApplicationSize</c>, or the call will fail.</para>
			/// <para>SetApplicationViewState</para>
			/// <para>SetNativeDisplaySize</para>
			/// <para>SetScaleFactor</para>
			/// </summary>
			/// <returns>
			/// When this method returns successfully, receives a pointer to the size that the Windows Store app should occupy, based on the
			/// current set of spoofed settings.
			/// </returns>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-computeapplicationsize
			// HRESULT ComputeApplicationSize( SIZE *applicationSizePixels );
			SIZE ComputeApplicationSize();

			/// <summary>
			/// <para>
			/// Determines whether a particular application view state is supported for specific spoofed display size and scale factor settings.
			/// </para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// </summary>
			/// <param name="viewState">
			/// One of the enumeration values that indicates the application view state for which support is being determined.
			/// </param>
			/// <param name="nativeDisplaySizePixels">The native size of the display to spoof.</param>
			/// <param name="scaleFactor">One of the enumeration values that indicates the device scale factor to spoof.</param>
			/// <returns>
			/// When this method returns successfully, receives a pointer to a Boolean value which is set to <c>TRUE</c> if the application
			/// view state is supported for the given display size and scale factor, and <c>FALSE</c> if it is not.
			/// </returns>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-isapplicationviewstatesupported
			// HRESULT IsApplicationViewStateSupported( APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR
			// scaleFactor, BOOL *supported );
			[return: MarshalAs(UnmanagedType.Bool)]
			bool IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor);

			/// <summary>
			/// <para>
			/// Sends a spoofed edge gesture event to the proxy core window on the caller's thread. This gesture toggles the app's app bar,
			/// if the app supports one. The caller can specify the type of input that triggered the edge gesture.
			/// </para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// </summary>
			/// <param name="edgeGestureKind">
			/// <para>
			/// Indicates the <c>EDGE_GESTURE_KIND</c> input type that generated the spoofed edge gesture. If touch ( <c>EGK_TOUCH</c>) is
			/// specified, both the <c>Starting</c> and <c>Completed</c> edge gesture events are sent. Otherwise, only the <c>Completed</c>
			/// event is sent. One of the following values:
			/// </para>
			/// <para>EGK_TOUCH (0)</para>
			/// <para>The edge gesture event was generated by a swipe on a touch-enabled screen.</para>
			/// <para>EGK_KEYBOARD (1)</para>
			/// <para>The edge gesture event was generated by the Win+Z key sequence on the keyboard.</para>
			/// <para>EGK_MOUSE (2)</para>
			/// <para>The edge gesture event was generated by a right mouse click.</para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-triggeredgegesture
			// HRESULT TriggerEdgeGesture( EDGE_GESTURE_KIND edgeGestureKind );
			void TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind);
		}

		/// <summary>
		/// Enables development tool applications to dynamically control system and user states, such as native display resolution, device
		/// scale factor, and application view layout, reported to Windows Store apps for the purpose of testing Windows Store apps running
		/// in design mode for a wide range of form factors without the need for the actual hardware. Also enables testing of changes in
		/// normally user-controlled state to test Windows Store apps under a variety of scenarios.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This interface is acquired by cocreating CLSID_ApplicationDesignModeSettings. It is an extension of the original
		/// IApplicationDesignModeSettings interface.
		/// </para>
		/// <para>Examples</para>
		/// <para>
		/// In this example, Visual Studio is launching an application in design mode that has overridden the minimum width on a display of
		/// size 1366x768. It is then enabling a slider control that allows the user to dynamically change the applications width. To do
		/// this, it needs to use the new SetApplicationViewMinWidth and GetApplicationSizeBoundsAPIs to compute the minimum and maximum
		/// sizes allowed for this type of application.
		/// </para>
		/// </remarks>
		// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationdesignmodesettings2
		[ComImport, Guid("490514E1-675A-4D6E-A58D-E54901B4CA2F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(ApplicationDesignModeSettings))]
		public interface IApplicationDesignModeSettings2 : IApplicationDesignModeSettings
		{
			/// <summary>
			/// <para>Sets a spoofed native display size to be used for a Windows Store app running in design mode.</para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para><c>SetNativeDisplaySize</c> must be called before calling ComputeApplicationSize.</para>
			/// </summary>
			/// <param name="nativeDisplaySizePixels">
			/// The native size of the display to spoof, as a SIZE structure. The specified size will be normalized to a landscape
			/// orientation. To spoof orientation, see SetApplicationViewState.
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setnativedisplaysize
			// HRESULT SetNativeDisplaySize( SIZE nativeDisplaySizePixels );
			new void SetNativeDisplaySize(SIZE nativeDisplaySizePixels);

			/// <summary>
			/// <para>Sets a spoofed device scale factor to be used for a Windows Store app running in design mode.</para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para><c>SetScaleFactor</c> must be called before calling ComputeApplicationSize.</para>
			/// </summary>
			/// <param name="scaleFactor">One of the DEVICE_SCALE_FACTOR enumeration values that indicates the device scale factor to spoof.</param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setscalefactor
			// HRESULT SetScaleFactor( DEVICE_SCALE_FACTOR scaleFactor );
			new void SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor);

			/// <summary>
			/// <para>
			/// Sets a spoofed application view state (full-screen landscape, full-screen portrait, filled, or snapped) to be used for a
			/// Windows Store app running in design mode.
			/// </para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para><c>SetApplicationViewState</c> must be called before calling ComputeApplicationSize.</para>
			/// </summary>
			/// <param name="viewState">
			/// One of the APPLICATION_VIEW_STATE enumeration values that indicates the application view state to spoof.
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-setapplicationviewstate
			// HRESULT SetApplicationViewState( APPLICATION_VIEW_STATE viewState );
			new void SetApplicationViewState(APPLICATION_VIEW_STATE viewState);

			/// <summary>
			/// <para>Gets the size of the Windows Store app, based on the current set of spoofed settings.</para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// <para>In addition, each of these methods must be called before calling <c>ComputeApplicationSize</c>, or the call will fail.</para>
			/// <para>SetApplicationViewState</para>
			/// <para>SetNativeDisplaySize</para>
			/// <para>SetScaleFactor</para>
			/// </summary>
			/// <returns>
			/// When this method returns successfully, receives a pointer to the size that the Windows Store app should occupy, based on the
			/// current set of spoofed settings.
			/// </returns>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-computeapplicationsize
			// HRESULT ComputeApplicationSize( SIZE *applicationSizePixels );
			new SIZE ComputeApplicationSize();

			/// <summary>
			/// <para>
			/// Determines whether a particular application view state is supported for specific spoofed display size and scale factor settings.
			/// </para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// </summary>
			/// <param name="viewState">
			/// One of the enumeration values that indicates the application view state for which support is being determined.
			/// </param>
			/// <param name="nativeDisplaySizePixels">The native size of the display to spoof.</param>
			/// <param name="scaleFactor">One of the enumeration values that indicates the device scale factor to spoof.</param>
			/// <returns>
			/// When this method returns successfully, receives a pointer to a Boolean value which is set to <c>TRUE</c> if the application
			/// view state is supported for the given display size and scale factor, and <c>FALSE</c> if it is not.
			/// </returns>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-isapplicationviewstatesupported
			// HRESULT IsApplicationViewStateSupported( APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR
			// scaleFactor, BOOL *supported );
			[return: MarshalAs(UnmanagedType.Bool)]
			new bool IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor);

			/// <summary>
			/// <para>
			/// Sends a spoofed edge gesture event to the proxy core window on the caller's thread. This gesture toggles the app's app bar,
			/// if the app supports one. The caller can specify the type of input that triggered the edge gesture.
			/// </para>
			/// <para>You must call IInitializeWithWindow::Initialize to set a proxy core window before calling this method.</para>
			/// </summary>
			/// <param name="edgeGestureKind">
			/// <para>
			/// Indicates the <c>EDGE_GESTURE_KIND</c> input type that generated the spoofed edge gesture. If touch ( <c>EGK_TOUCH</c>) is
			/// specified, both the <c>Starting</c> and <c>Completed</c> edge gesture events are sent. Otherwise, only the <c>Completed</c>
			/// event is sent. One of the following values:
			/// </para>
			/// <para>EGK_TOUCH (0)</para>
			/// <para>The edge gesture event was generated by a swipe on a touch-enabled screen.</para>
			/// <para>EGK_KEYBOARD (1)</para>
			/// <para>The edge gesture event was generated by the Win+Z key sequence on the keyboard.</para>
			/// <para>EGK_MOUSE (2)</para>
			/// <para>The edge gesture event was generated by a right mouse click.</para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings-triggeredgegesture
			// HRESULT TriggerEdgeGesture( EDGE_GESTURE_KIND edgeGestureKind );
			new void TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind);

			/// <summary>Sets the orientation of the emulated display for the design mode window.</summary>
			/// <param name="nativeDisplayOrientation">
			/// <para>Type: <c>NATIVE_DISPLAY_ORIENTATION</c></para>
			/// <para>The native orientation of the display to emulate.</para>
			/// <para>NDO_LANDSCAPE (0)</para>
			/// <para>Landscape orientation, with the display width greater than the height.</para>
			/// <para>NDO_PORTRAIT (1)</para>
			/// <para>Portrait orientation, with the display height greater than the width.</para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setnativedisplayorientation
			// HRESULT SetNativeDisplayOrientation( NATIVE_DISPLAY_ORIENTATION nativeDisplayOrientation );
			void SetNativeDisplayOrientation(NATIVE_DISPLAY_ORIENTATION nativeDisplayOrientation);

			/// <summary>Sets the window orientation used for the design mode window.</summary>
			/// <param name="viewOrientation">
			/// <para>Type: <c>APPLICATION_VIEW_ORIENTATION</c></para>
			/// <para>The orientation of the design mode window to use. Either <c>AVO_LANDSCAPE</c> or <c>AVO_PORTRAIT</c>.</para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setapplicationvieworientation
			// HRESULT SetApplicationViewOrientation( APPLICATION_VIEW_ORIENTATION viewOrientation );
			void SetApplicationViewOrientation(APPLICATION_VIEW_ORIENTATION viewOrientation);

			/// <summary>Sets whether the application window will be adjacent to the edge of the emulated display.</summary>
			/// <param name="adjacentDisplayEdges">
			/// <para>Type: <c>ADJACENT_DISPLAY_EDGES</c></para>
			/// <para>The edge which should be adjacent.</para>
			/// <para>ADE_NONE (0x0)</para>
			/// <para>The widow will not be adjacent to either edge.</para>
			/// <para>ADE_LEFT (0x1)</para>
			/// <para>the left edge of the window will be adjacent.</para>
			/// <para>ADE_RIGHT (0x2)</para>
			/// <para>The right edge of the window will be adjacent.</para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setadjacentdisplayedges
			// HRESULT SetAdjacentDisplayEdges( ADJACENT_DISPLAY_EDGES adjacentDisplayEdges );
			void SetAdjacentDisplayEdges(ADJACENT_DISPLAY_EDGES adjacentDisplayEdges);

			/// <summary>
			/// This method determines whether or not the application, in design mode, can display information on the Windows 8 lock screen.
			/// </summary>
			/// <param name="isOnLockScreen">
			/// <para>Type: <c>BOOL</c></para>
			/// <para>
			/// When set to <c>TRUE</c>, the application will display information on the lock screen. When set to <c>FALSE</c>, information
			/// will not be displayed.
			/// </para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setisonlockscreen
			// HRESULT SetIsOnLockScreen( BOOL isOnLockScreen );
			void SetIsOnLockScreen([MarshalAs(UnmanagedType.Bool)] bool isOnLockScreen);

			/// <summary>Sets the desired minimum width of the application design mode window.</summary>
			/// <param name="viewMinWidth">
			/// <para>Type: <c>APPLICATION_VIEW_MIN_WIDTH</c></para>
			/// <para>The minimum width value.</para>
			/// <para>AVMW_DEFAULT (0)</para>
			/// <para>Uses the default minimum width.</para>
			/// <para>AVMW_320 (1)</para>
			/// <para>Sets the minimum width at 320 pixels.</para>
			/// <para>AVMW_500 (2)</para>
			/// <para>Sets the minimum width at 500 pixels.</para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-setapplicationviewminwidth
			// HRESULT SetApplicationViewMinWidth( APPLICATION_VIEW_MIN_WIDTH viewMinWidth );
			void SetApplicationViewMinWidth(APPLICATION_VIEW_MIN_WIDTH viewMinWidth);

			/// <summary>This methods retrieves the size bounds supported by the application.</summary>
			/// <param name="minApplicationSizePixels">
			/// <para>Type: <c>SIZE*</c></para>
			/// <para>
			/// When this method returns successfully, receives a pointer to a SIZE structure that defines the minimum possible window size.
			/// </para>
			/// </param>
			/// <param name="maxApplicationSizePixels">
			/// <para>Type: <c>SIZE*</c></para>
			/// <para>
			/// When this method returns successfully, receives a pointer to a SIZE structure that defines the maximum possible window size.
			/// </para>
			/// </param>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-getapplicationsizebounds
			// HRESULT GetApplicationSizeBounds( SIZE *minApplicationSizePixels, SIZE *maxApplicationSizePixels );
			void GetApplicationSizeBounds(out SIZE minApplicationSizePixels, out SIZE maxApplicationSizePixels);

			/// <summary>Gets the orientation of the application design mode window.</summary>
			/// <param name="applicationSizePixels">
			/// <para>Type: <c>SIZE</c></para>
			/// <para>The application window size.</para>
			/// </param>
			/// <returns>
			/// <para>Type: <c>APPLICATION_VIEW_ORIENTATION*</c></para>
			/// <para>When this method returns successfully, receives a pointer to an APPLICATION_VIEW_ORIENTATION structure.</para>
			/// </returns>
			// https://docs.microsoft.com/en-us/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdesignmodesettings2-getapplicationvieworientation
			// HRESULT GetApplicationViewOrientation( SIZE applicationSizePixels, APPLICATION_VIEW_ORIENTATION *viewOrientation );
			APPLICATION_VIEW_ORIENTATION GetApplicationViewOrientation(SIZE applicationSizePixels);
		}

		/// <summary>CLSID_ApplicationDesignModeSettings</summary>
		[PInvokeData("shobjidl.h")]
		[ComImport, Guid("958a6fb5-dcb2-4faf-aafd-7fb054ad1a3b"), ClassInterface(ClassInterfaceType.None)]
		public class ApplicationDesignModeSettings { }
	}
}