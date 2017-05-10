﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Y.Core.Enum;


namespace Y.Core.ComFunc
{
    /// <summary>
	/// FontAwesome static helper object,default icon size is 32,no border,backcolor is Color.Transparent,forecolor is Color.Black,border color is Color.Gray.
	/// </summary>
	/// <example>
	/// defalut:
	/// Bitmap bmp = FontAwesome.GetImage(0xf188);
	/// Icon ico = FontAwesome.GetIcon(0xf188);
	/// custom:
	/// FontAwesome.IconSize = 128;//change icon size
	/// FontAwesome.ForeColer = Color.Purple;//change icon forecolor
	/// Bitmap bmp = FontAwesome.GetImage(0xf188);
	/// Icon ico = FontAwesome.GetIcon(0xf188);
	/// </example>
	public class FontAwesome
    {
        /// <summary>
        /// FontAwesome Name
        /// </summary>
        private static readonly string FontAwesomeName;
        /// <summary>
        /// FontAwesome Location
        /// </summary>
        private static readonly string FontAwesomeLocation;
        /// <summary>
        /// FontCollection object
        /// </summary>
        private static readonly PrivateFontCollection FontCollection;
        /// <summary>
        /// FontAwesome Version
        /// </summary>
        public static readonly string FontAwesomeVersion;
        private const int FW_HEAVY = 200;
        private const int ANSI_CHARSET = 0;
        private const int OUT_DEFAULT_PRECIS = 0;
        private const int CLIP_DEFAULT_PRECIS = 0;
        private const int DEFAULT_QUALITY = 0;
        private const int DEFAULT_PITCH = 0;
        private const int FF_SWISS = 32;
        private const int TRANSPARENT = 1;
        /// <summary>
        /// Type Dictionary
        /// </summary>
        public static Dictionary<string, int> TypeDict;
        /// <summary>
        /// icon image size
        /// </summary>
        public static int IconSize
        {
            get;
            set;
        }
        /// <summary>
        /// border visible
        /// </summary>
        public static bool BorderVisible
        {
            get;
            set;
        }
        /// <summary>
        /// icon image backcolor
        /// </summary>
        public static Color BackColer
        {
            get;
            set;
        }
        /// <summary>
        /// icon image forecolor
        /// </summary>
        public static Color ForeColer
        {
            get;
            set;
        }
        /// <summary>
        /// icon image border color
        /// </summary>
        public static Color BorderColer
        {
            get;
            set;
        }
        public static int Top
        {
            get;
            set;
        }
        public static int Left
        {
            get;
            set;
        }
        /// <summary>
        /// ctor with no params
        /// </summary>
        static FontAwesome()
        {
            FontAwesome.FontAwesomeName = "fontawesome-webfont.ttf";
            FontAwesome.FontAwesomeLocation = "font\\";
            FontAwesome.FontCollection = new PrivateFontCollection();
            FontAwesome.FontAwesomeVersion = "4.7.0";
            FontAwesome.TypeDict = new Dictionary<string, int>
            {

                {
                    "fa-glass",
                    61440
                },

                {
                    "fa-music",
                    61441
                },

                {
                    "fa-search",
                    61442
                },

                {
                    "fa-envelope-o",
                    61443
                },

                {
                    "fa-heart",
                    61444
                },

                {
                    "fa-star",
                    61445
                },

                {
                    "fa-star-o",
                    61446
                },

                {
                    "fa-user",
                    61447
                },

                {
                    "fa-film",
                    61448
                },

                {
                    "fa-th-large",
                    61449
                },

                {
                    "fa-th",
                    61450
                },

                {
                    "fa-th-list",
                    61451
                },

                {
                    "fa-check",
                    61452
                },

                {
                    "fa-times",
                    61453
                },

                {
                    "fa-remove",
                    61453
                },

                {
                    "fa-close",
                    61453
                },

                {
                    "fa-search-plus",
                    61454
                },

                {
                    "fa-search-minus",
                    61456
                },

                {
                    "fa-power-off",
                    61457
                },

                {
                    "fa-signal",
                    61458
                },

                {
                    "fa-cog",
                    61459
                },

                {
                    "fa-gear",
                    61459
                },

                {
                    "fa-trash-o",
                    61460
                },

                {
                    "fa-home",
                    61461
                },

                {
                    "fa-file-o",
                    61462
                },

                {
                    "fa-clock-o",
                    61463
                },

                {
                    "fa-road",
                    61464
                },

                {
                    "fa-download",
                    61465
                },

                {
                    "fa-arrow-circle-o-down",
                    61466
                },

                {
                    "fa-arrow-circle-o-up",
                    61467
                },

                {
                    "fa-inbox",
                    61468
                },

                {
                    "fa-play-circle-o",
                    61469
                },

                {
                    "fa-repeat",
                    61470
                },

                {
                    "fa-rotate-right",
                    61470
                },

                {
                    "fa-refresh",
                    61473
                },

                {
                    "fa-list-alt",
                    61474
                },

                {
                    "fa-lock",
                    61475
                },

                {
                    "fa-flag",
                    61476
                },

                {
                    "fa-headphones",
                    61477
                },

                {
                    "fa-volume-off",
                    61478
                },

                {
                    "fa-volume-down",
                    61479
                },

                {
                    "fa-volume-up",
                    61480
                },

                {
                    "fa-qrcode",
                    61481
                },

                {
                    "fa-barcode",
                    61482
                },

                {
                    "fa-tag",
                    61483
                },

                {
                    "fa-tags",
                    61484
                },

                {
                    "fa-book",
                    61485
                },

                {
                    "fa-bookmark",
                    61486
                },

                {
                    "fa-print",
                    61487
                },

                {
                    "fa-camera",
                    61488
                },

                {
                    "fa-font",
                    61489
                },

                {
                    "fa-bold",
                    61490
                },

                {
                    "fa-italic",
                    61491
                },

                {
                    "fa-text-height",
                    61492
                },

                {
                    "fa-text-width",
                    61493
                },

                {
                    "fa-align-left",
                    61494
                },

                {
                    "fa-align-center",
                    61495
                },

                {
                    "fa-align-right",
                    61496
                },

                {
                    "fa-align-justify",
                    61497
                },

                {
                    "fa-list",
                    61498
                },

                {
                    "fa-outdent",
                    61499
                },

                {
                    "fa-dedent",
                    61499
                },

                {
                    "fa-indent",
                    61500
                },

                {
                    "fa-video-camera",
                    61501
                },

                {
                    "fa-picture-o",
                    61502
                },

                {
                    "fa-photo",
                    61502
                },

                {
                    "fa-image",
                    61502
                },

                {
                    "fa-pencil",
                    61504
                },

                {
                    "fa-map-marker",
                    61505
                },

                {
                    "fa-adjust",
                    61506
                },

                {
                    "fa-tint",
                    61507
                },

                {
                    "fa-pencil-square-o",
                    61508
                },

                {
                    "fa-edit",
                    61508
                },

                {
                    "fa-share-square-o",
                    61509
                },

                {
                    "fa-check-square-o",
                    61510
                },

                {
                    "fa-arrows",
                    61511
                },

                {
                    "fa-step-backward",
                    61512
                },

                {
                    "fa-fast-backward",
                    61513
                },

                {
                    "fa-backward",
                    61514
                },

                {
                    "fa-play",
                    61515
                },

                {
                    "fa-pause",
                    61516
                },

                {
                    "fa-stop",
                    61517
                },

                {
                    "fa-forward",
                    61518
                },

                {
                    "fa-fast-forward",
                    61520
                },

                {
                    "fa-step-forward",
                    61521
                },

                {
                    "fa-eject",
                    61522
                },

                {
                    "fa-chevron-left",
                    61523
                },

                {
                    "fa-chevron-right",
                    61524
                },

                {
                    "fa-plus-circle",
                    61525
                },

                {
                    "fa-minus-circle",
                    61526
                },

                {
                    "fa-times-circle",
                    61527
                },

                {
                    "fa-check-circle",
                    61528
                },

                {
                    "fa-question-circle",
                    61529
                },

                {
                    "fa-info-circle",
                    61530
                },

                {
                    "fa-crosshairs",
                    61531
                },

                {
                    "fa-times-circle-o",
                    61532
                },

                {
                    "fa-check-circle-o",
                    61533
                },

                {
                    "fa-ban",
                    61534
                },

                {
                    "fa-arrow-left",
                    61536
                },

                {
                    "fa-arrow-right",
                    61537
                },

                {
                    "fa-arrow-up",
                    61538
                },

                {
                    "fa-arrow-down",
                    61539
                },

                {
                    "fa-share",
                    61540
                },

                {
                    "fa-mail-forward",
                    61540
                },

                {
                    "fa-expand",
                    61541
                },

                {
                    "fa-compress",
                    61542
                },

                {
                    "fa-plus",
                    61543
                },

                {
                    "fa-minus",
                    61544
                },

                {
                    "fa-asterisk",
                    61545
                },

                {
                    "fa-exclamation-circle",
                    61546
                },

                {
                    "fa-gift",
                    61547
                },

                {
                    "fa-leaf",
                    61548
                },

                {
                    "fa-fire",
                    61549
                },

                {
                    "fa-eye",
                    61550
                },

                {
                    "fa-eye-slash",
                    61552
                },

                {
                    "fa-exclamation-triangle",
                    61553
                },

                {
                    "fa-warning",
                    61553
                },

                {
                    "fa-plane",
                    61554
                },

                {
                    "fa-calendar",
                    61555
                },

                {
                    "fa-random",
                    61556
                },

                {
                    "fa-comment",
                    61557
                },

                {
                    "fa-magnet",
                    61558
                },

                {
                    "fa-chevron-up",
                    61559
                },

                {
                    "fa-chevron-down",
                    61560
                },

                {
                    "fa-retweet",
                    61561
                },

                {
                    "fa-shopping-cart",
                    61562
                },

                {
                    "fa-folder",
                    61563
                },

                {
                    "fa-folder-open",
                    61564
                },

                {
                    "fa-arrows-v",
                    61565
                },

                {
                    "fa-arrows-h",
                    61566
                },

                {
                    "fa-bar-chart",
                    61568
                },

                {
                    "fa-bar-chart-o",
                    61568
                },

                {
                    "fa-twitter-square",
                    61569
                },

                {
                    "fa-facebook-square",
                    61570
                },

                {
                    "fa-camera-retro",
                    61571
                },

                {
                    "fa-key",
                    61572
                },

                {
                    "fa-cogs",
                    61573
                },

                {
                    "fa-gears",
                    61573
                },

                {
                    "fa-comments",
                    61574
                },

                {
                    "fa-thumbs-o-up",
                    61575
                },

                {
                    "fa-thumbs-o-down",
                    61576
                },

                {
                    "fa-star-half",
                    61577
                },

                {
                    "fa-heart-o",
                    61578
                },

                {
                    "fa-sign-out",
                    61579
                },

                {
                    "fa-linkedin-square",
                    61580
                },

                {
                    "fa-thumb-tack",
                    61581
                },

                {
                    "fa-external-link",
                    61582
                },

                {
                    "fa-sign-in",
                    61584
                },

                {
                    "fa-trophy",
                    61585
                },

                {
                    "fa-github-square",
                    61586
                },

                {
                    "fa-upload",
                    61587
                },

                {
                    "fa-lemon-o",
                    61588
                },

                {
                    "fa-phone",
                    61589
                },

                {
                    "fa-square-o",
                    61590
                },

                {
                    "fa-bookmark-o",
                    61591
                },

                {
                    "fa-phone-square",
                    61592
                },

                {
                    "fa-twitter",
                    61593
                },

                {
                    "fa-facebook",
                    61594
                },

                {
                    "fa-facebook-f",
                    61594
                },

                {
                    "fa-github",
                    61595
                },

                {
                    "fa-unlock",
                    61596
                },

                {
                    "fa-credit-card",
                    61597
                },

                {
                    "fa-rss",
                    61598
                },

                {
                    "fa-feed",
                    61598
                },

                {
                    "fa-hdd-o",
                    61600
                },

                {
                    "fa-bullhorn",
                    61601
                },

                {
                    "fa-bell",
                    61683
                },

                {
                    "fa-certificate",
                    61603
                },

                {
                    "fa-hand-o-right",
                    61604
                },

                {
                    "fa-hand-o-left",
                    61605
                },

                {
                    "fa-hand-o-up",
                    61606
                },

                {
                    "fa-hand-o-down",
                    61607
                },

                {
                    "fa-arrow-circle-left",
                    61608
                },

                {
                    "fa-arrow-circle-right",
                    61609
                },

                {
                    "fa-arrow-circle-up",
                    61610
                },

                {
                    "fa-arrow-circle-down",
                    61611
                },

                {
                    "fa-globe",
                    61612
                },

                {
                    "fa-wrench",
                    61613
                },

                {
                    "fa-tasks",
                    61614
                },

                {
                    "fa-filter",
                    61616
                },

                {
                    "fa-briefcase",
                    61617
                },

                {
                    "fa-arrows-alt",
                    61618
                },

                {
                    "fa-users",
                    61632
                },

                {
                    "fa-group",
                    61632
                },

                {
                    "fa-link",
                    61633
                },

                {
                    "fa-chain",
                    61633
                },

                {
                    "fa-cloud",
                    61634
                },

                {
                    "fa-flask",
                    61635
                },

                {
                    "fa-scissors",
                    61636
                },

                {
                    "fa-cut",
                    61636
                },

                {
                    "fa-files-o",
                    61637
                },

                {
                    "fa-copy",
                    61637
                },

                {
                    "fa-paperclip",
                    61638
                },

                {
                    "fa-floppy-o",
                    61639
                },

                {
                    "fa-save",
                    61639
                },

                {
                    "fa-square",
                    61640
                },

                {
                    "fa-bars",
                    61641
                },

                {
                    "fa-navicon",
                    61641
                },

                {
                    "fa-reorder",
                    61641
                },

                {
                    "fa-list-ul",
                    61642
                },

                {
                    "fa-list-ol",
                    61643
                },

                {
                    "fa-strikethrough",
                    61644
                },

                {
                    "fa-underline",
                    61645
                },

                {
                    "fa-table",
                    61646
                },

                {
                    "fa-magic",
                    61648
                },

                {
                    "fa-truck",
                    61649
                },

                {
                    "fa-pinterest",
                    61650
                },

                {
                    "fa-pinterest-square",
                    61651
                },

                {
                    "fa-google-plus-square",
                    61652
                },

                {
                    "fa-google-plus",
                    61653
                },

                {
                    "fa-money",
                    61654
                },

                {
                    "fa-caret-down",
                    61655
                },

                {
                    "fa-caret-up",
                    61656
                },

                {
                    "fa-caret-left",
                    61657
                },

                {
                    "fa-caret-right",
                    61658
                },

                {
                    "fa-columns",
                    61659
                },

                {
                    "fa-sort",
                    61660
                },

                {
                    "fa-unsorted",
                    61660
                },

                {
                    "fa-sort-desc",
                    61661
                },

                {
                    "fa-sort-down",
                    61661
                },

                {
                    "fa-sort-asc",
                    61662
                },

                {
                    "fa-sort-up",
                    61662
                },

                {
                    "fa-envelope",
                    61664
                },

                {
                    "fa-linkedin",
                    61665
                },

                {
                    "fa-undo",
                    61666
                },

                {
                    "fa-rotate-left",
                    61666
                },

                {
                    "fa-gavel",
                    61667
                },

                {
                    "fa-legal",
                    61667
                },

                {
                    "fa-tachometer",
                    61668
                },

                {
                    "fa-dashboard",
                    61668
                },

                {
                    "fa-comment-o",
                    61669
                },

                {
                    "fa-comments-o",
                    61670
                },

                {
                    "fa-bolt",
                    61671
                },

                {
                    "fa-flash",
                    61671
                },

                {
                    "fa-sitemap",
                    61672
                },

                {
                    "fa-umbrella",
                    61673
                },

                {
                    "fa-clipboard",
                    61674
                },

                {
                    "fa-paste",
                    61674
                },

                {
                    "fa-lightbulb-o",
                    61675
                },

                {
                    "fa-exchange",
                    61676
                },

                {
                    "fa-cloud-download",
                    61677
                },

                {
                    "fa-cloud-upload",
                    61678
                },

                {
                    "fa-user-md",
                    61680
                },

                {
                    "fa-stethoscope",
                    61681
                },

                {
                    "fa-suitcase",
                    61682
                },

                {
                    "fa-bell-o",
                    61602
                },

                {
                    "fa-coffee",
                    61684
                },

                {
                    "fa-cutlery",
                    61685
                },

                {
                    "fa-file-text-o",
                    61686
                },

                {
                    "fa-building-o",
                    61687
                },

                {
                    "fa-hospital-o",
                    61688
                },

                {
                    "fa-ambulance",
                    61689
                },

                {
                    "fa-medkit",
                    61690
                },

                {
                    "fa-fighter-jet",
                    61691
                },

                {
                    "fa-beer",
                    61692
                },

                {
                    "fa-h-square",
                    61693
                },

                {
                    "fa-plus-square",
                    61694
                },

                {
                    "fa-angle-double-left",
                    61696
                },

                {
                    "fa-angle-double-right",
                    61697
                },

                {
                    "fa-angle-double-up",
                    61698
                },

                {
                    "fa-angle-double-down",
                    61699
                },

                {
                    "fa-angle-left",
                    61700
                },

                {
                    "fa-angle-right",
                    61701
                },

                {
                    "fa-angle-up",
                    61702
                },

                {
                    "fa-angle-down",
                    61703
                },

                {
                    "fa-desktop",
                    61704
                },

                {
                    "fa-laptop",
                    61705
                },

                {
                    "fa-tablet",
                    61706
                },

                {
                    "fa-mobile",
                    61707
                },

                {
                    "fa-mobile-phone",
                    61707
                },

                {
                    "fa-circle-o",
                    61708
                },

                {
                    "fa-quote-left",
                    61709
                },

                {
                    "fa-quote-right",
                    61710
                },

                {
                    "fa-spinner",
                    61712
                },

                {
                    "fa-circle",
                    61713
                },

                {
                    "fa-reply",
                    61714
                },

                {
                    "fa-mail-reply",
                    61714
                },

                {
                    "fa-github-alt",
                    61715
                },

                {
                    "fa-folder-o",
                    61716
                },

                {
                    "fa-folder-open-o",
                    61717
                },

                {
                    "fa-smile-o",
                    61720
                },

                {
                    "fa-frown-o",
                    61721
                },

                {
                    "fa-meh-o",
                    61722
                },

                {
                    "fa-gamepad",
                    61723
                },

                {
                    "fa-keyboard-o",
                    61724
                },

                {
                    "fa-flag-o",
                    61725
                },

                {
                    "fa-flag-checkered",
                    61726
                },

                {
                    "fa-terminal",
                    61728
                },

                {
                    "fa-code",
                    61729
                },

                {
                    "fa-reply-all",
                    61730
                },

                {
                    "fa-mail-reply-all",
                    61730
                },

                {
                    "fa-star-half-o",
                    61731
                },

                {
                    "fa-star-half-empty",
                    61731
                },

                {
                    "fa-star-half-full",
                    61731
                },

                {
                    "fa-location-arrow",
                    61732
                },

                {
                    "fa-crop",
                    61733
                },

                {
                    "fa-code-fork",
                    61734
                },

                {
                    "fa-chain-broken",
                    61735
                },

                {
                    "fa-unlink",
                    61735
                },

                {
                    "fa-question",
                    61736
                },

                {
                    "fa-info",
                    61737
                },

                {
                    "fa-exclamation",
                    61738
                },

                {
                    "fa-superscript",
                    61739
                },

                {
                    "fa-subscript",
                    61740
                },

                {
                    "fa-eraser",
                    61741
                },

                {
                    "fa-puzzle-piece",
                    61742
                },

                {
                    "fa-microphone",
                    61744
                },

                {
                    "fa-microphone-slash",
                    61745
                },

                {
                    "fa-shield",
                    61746
                },

                {
                    "fa-calendar-o",
                    61747
                },

                {
                    "fa-fire-extinguisher",
                    61748
                },

                {
                    "fa-rocket",
                    61749
                },

                {
                    "fa-maxcdn",
                    61750
                },

                {
                    "fa-chevron-circle-left",
                    61751
                },

                {
                    "fa-chevron-circle-right",
                    61752
                },

                {
                    "fa-chevron-circle-up",
                    61753
                },

                {
                    "fa-chevron-circle-down",
                    61754
                },

                {
                    "fa-html5",
                    61755
                },

                {
                    "fa-css3",
                    61756
                },

                {
                    "fa-anchor",
                    61757
                },

                {
                    "fa-unlock-alt",
                    61758
                },

                {
                    "fa-bullseye",
                    61760
                },

                {
                    "fa-ellipsis-h",
                    61761
                },

                {
                    "fa-ellipsis-v",
                    61762
                },

                {
                    "fa-rss-square",
                    61763
                },

                {
                    "fa-play-circle",
                    61764
                },

                {
                    "fa-ticket",
                    61765
                },

                {
                    "fa-minus-square",
                    61766
                },

                {
                    "fa-minus-square-o",
                    61767
                },

                {
                    "fa-level-up",
                    61768
                },

                {
                    "fa-level-down",
                    61769
                },

                {
                    "fa-check-square",
                    61770
                },

                {
                    "fa-pencil-square",
                    61771
                },

                {
                    "fa-external-link-square",
                    61772
                },

                {
                    "fa-share-square",
                    61773
                },

                {
                    "fa-compass",
                    61774
                },

                {
                    "fa-caret-square-o-down",
                    61776
                },

                {
                    "fa-toggle-down",
                    61776
                },

                {
                    "fa-caret-square-o-up",
                    61777
                },

                {
                    "fa-toggle-up",
                    61777
                },

                {
                    "fa-caret-square-o-right",
                    61778
                },

                {
                    "fa-toggle-right",
                    61778
                },

                {
                    "fa-eur",
                    61779
                },

                {
                    "fa-euro",
                    61779
                },

                {
                    "fa-gbp",
                    61780
                },

                {
                    "fa-usd",
                    61781
                },

                {
                    "fa-dollar",
                    61781
                },

                {
                    "fa-inr",
                    61782
                },

                {
                    "fa-rupee",
                    61782
                },

                {
                    "fa-jpy",
                    61783
                },

                {
                    "fa-cny",
                    61783
                },

                {
                    "fa-rmb",
                    61783
                },

                {
                    "fa-yen",
                    61783
                },

                {
                    "fa-rub",
                    61784
                },

                {
                    "fa-ruble",
                    61784
                },

                {
                    "fa-rouble",
                    61784
                },

                {
                    "fa-krw",
                    61785
                },

                {
                    "fa-won",
                    61785
                },

                {
                    "fa-btc",
                    61786
                },

                {
                    "fa-bitcoin",
                    61786
                },

                {
                    "fa-file",
                    61787
                },

                {
                    "fa-file-text",
                    61788
                },

                {
                    "fa-sort-alpha-asc",
                    61789
                },

                {
                    "fa-sort-alpha-desc",
                    61790
                },

                {
                    "fa-sort-amount-asc",
                    61792
                },

                {
                    "fa-sort-amount-desc",
                    61793
                },

                {
                    "fa-sort-numeric-asc",
                    61794
                },

                {
                    "fa-sort-numeric-desc",
                    61795
                },

                {
                    "fa-thumbs-up",
                    61796
                },

                {
                    "fa-thumbs-down",
                    61797
                },

                {
                    "fa-youtube-square",
                    61798
                },

                {
                    "fa-youtube",
                    61799
                },

                {
                    "fa-xing",
                    61800
                },

                {
                    "fa-xing-square",
                    61801
                },

                {
                    "fa-youtube-play",
                    61802
                },

                {
                    "fa-dropbox",
                    61803
                },

                {
                    "fa-stack-overflow",
                    61804
                },

                {
                    "fa-instagram",
                    61805
                },

                {
                    "fa-flickr",
                    61806
                },

                {
                    "fa-adn",
                    61808
                },

                {
                    "fa-bitbucket",
                    61809
                },

                {
                    "fa-bitbucket-square",
                    61810
                },

                {
                    "fa-tumblr",
                    61811
                },

                {
                    "fa-tumblr-square",
                    61812
                },

                {
                    "fa-long-arrow-down",
                    61813
                },

                {
                    "fa-long-arrow-up",
                    61814
                },

                {
                    "fa-long-arrow-left",
                    61815
                },

                {
                    "fa-long-arrow-right",
                    61816
                },

                {
                    "fa-apple",
                    61817
                },

                {
                    "fa-windows",
                    61818
                },

                {
                    "fa-android",
                    61819
                },

                {
                    "fa-linux",
                    61820
                },

                {
                    "fa-dribbble",
                    61821
                },

                {
                    "fa-skype",
                    61822
                },

                {
                    "fa-foursquare",
                    61824
                },

                {
                    "fa-trello",
                    61825
                },

                {
                    "fa-female",
                    61826
                },

                {
                    "fa-male",
                    61827
                },

                {
                    "fa-gratipay",
                    61828
                },

                {
                    "fa-gittip",
                    61828
                },

                {
                    "fa-sun-o",
                    61829
                },

                {
                    "fa-moon-o",
                    61830
                },

                {
                    "fa-archive",
                    61831
                },

                {
                    "fa-bug",
                    61832
                },

                {
                    "fa-vk",
                    61833
                },

                {
                    "fa-weibo",
                    61834
                },

                {
                    "fa-renren",
                    61835
                },

                {
                    "fa-pagelines",
                    61836
                },

                {
                    "fa-stack-exchange",
                    61837
                },

                {
                    "fa-arrow-circle-o-right",
                    61838
                },

                {
                    "fa-arrow-circle-o-left",
                    61840
                },

                {
                    "fa-caret-square-o-left",
                    61841
                },

                {
                    "fa-toggle-left",
                    61841
                },

                {
                    "fa-dot-circle-o",
                    61842
                },

                {
                    "fa-wheelchair",
                    61843
                },

                {
                    "fa-vimeo-square",
                    61844
                },

                {
                    "fa-try",
                    61845
                },

                {
                    "fa-turkish-lira",
                    61845
                },

                {
                    "fa-plus-square-o",
                    61846
                },

                {
                    "fa-space-shuttle",
                    61847
                },

                {
                    "fa-slack",
                    61848
                },

                {
                    "fa-envelope-square",
                    61849
                },

                {
                    "fa-wordpress",
                    61850
                },

                {
                    "fa-openid",
                    61851
                },

                {
                    "fa-university",
                    61852
                },

                {
                    "fa-institution",
                    61852
                },

                {
                    "fa-bank",
                    61852
                },

                {
                    "fa-graduation-cap",
                    61853
                },

                {
                    "fa-mortar-board",
                    61853
                },

                {
                    "fa-yahoo",
                    61854
                },

                {
                    "fa-google",
                    61856
                },

                {
                    "fa-reddit",
                    61857
                },

                {
                    "fa-reddit-square",
                    61858
                },

                {
                    "fa-stumbleupon-circle",
                    61859
                },

                {
                    "fa-stumbleupon",
                    61860
                },

                {
                    "fa-delicious",
                    61861
                },

                {
                    "fa-digg",
                    61862
                },

                {
                    "fa-pied-piper-pp",
                    61863
                },

                {
                    "fa-pied-piper-alt",
                    61864
                },

                {
                    "fa-drupal",
                    61865
                },

                {
                    "fa-joomla",
                    61866
                },

                {
                    "fa-language",
                    61867
                },

                {
                    "fa-fax",
                    61868
                },

                {
                    "fa-building",
                    61869
                },

                {
                    "fa-child",
                    61870
                },

                {
                    "fa-paw",
                    61872
                },

                {
                    "fa-spoon",
                    61873
                },

                {
                    "fa-cube",
                    61874
                },

                {
                    "fa-cubes",
                    61875
                },

                {
                    "fa-behance",
                    61876
                },

                {
                    "fa-behance-square",
                    61877
                },

                {
                    "fa-steam",
                    61878
                },

                {
                    "fa-steam-square",
                    61879
                },

                {
                    "fa-recycle",
                    61880
                },

                {
                    "fa-car",
                    61881
                },

                {
                    "fa-automobile",
                    61881
                },

                {
                    "fa-taxi",
                    61882
                },

                {
                    "fa-cab",
                    61882
                },

                {
                    "fa-tree",
                    61883
                },

                {
                    "fa-spotify",
                    61884
                },

                {
                    "fa-deviantart",
                    61885
                },

                {
                    "fa-soundcloud",
                    61886
                },

                {
                    "fa-database",
                    61888
                },

                {
                    "fa-file-pdf-o",
                    61889
                },

                {
                    "fa-file-word-o",
                    61890
                },

                {
                    "fa-file-excel-o",
                    61891
                },

                {
                    "fa-file-powerpoint-o",
                    61892
                },

                {
                    "fa-file-image-o",
                    61893
                },

                {
                    "fa-file-photo-o",
                    61893
                },

                {
                    "fa-file-picture-o",
                    61893
                },

                {
                    "fa-file-archive-o",
                    61894
                },

                {
                    "fa-file-zip-o",
                    61894
                },

                {
                    "fa-file-audio-o",
                    61895
                },

                {
                    "fa-file-sound-o",
                    61895
                },

                {
                    "fa-file-video-o",
                    61896
                },

                {
                    "fa-file-movie-o",
                    61896
                },

                {
                    "fa-file-code-o",
                    61897
                },

                {
                    "fa-vine",
                    61898
                },

                {
                    "fa-codepen",
                    61899
                },

                {
                    "fa-jsfiddle",
                    61900
                },

                {
                    "fa-life-ring",
                    61901
                },

                {
                    "fa-life-bouy",
                    61901
                },

                {
                    "fa-life-buoy",
                    61901
                },

                {
                    "fa-life-saver",
                    61901
                },

                {
                    "fa-support",
                    61901
                },

                {
                    "fa-circle-o-notch",
                    61902
                },

                {
                    "fa-rebel",
                    61904
                },

                {
                    "fa-ra",
                    61904
                },

                {
                    "fa-resistance",
                    61904
                },

                {
                    "fa-empire",
                    61905
                },

                {
                    "fa-ge",
                    61905
                },

                {
                    "fa-git-square",
                    61906
                },

                {
                    "fa-git",
                    61907
                },

                {
                    "fa-hacker-news",
                    61908
                },

                {
                    "fa-y-combinator-square",
                    61908
                },

                {
                    "fa-yc-square",
                    61908
                },

                {
                    "fa-tencent-weibo",
                    61909
                },

                {
                    "fa-qq",
                    61910
                },

                {
                    "fa-weixin",
                    61911
                },

                {
                    "fa-wechat",
                    61911
                },

                {
                    "fa-paper-plane",
                    61912
                },

                {
                    "fa-send",
                    61912
                },

                {
                    "fa-paper-plane-o",
                    61913
                },

                {
                    "fa-send-o",
                    61913
                },

                {
                    "fa-history",
                    61914
                },

                {
                    "fa-circle-thin",
                    61915
                },

                {
                    "fa-header",
                    61916
                },

                {
                    "fa-paragraph",
                    61917
                },

                {
                    "fa-sliders",
                    61918
                },

                {
                    "fa-share-alt",
                    61920
                },

                {
                    "fa-share-alt-square",
                    61921
                },

                {
                    "fa-bomb",
                    61922
                },

                {
                    "fa-futbol-o",
                    61923
                },

                {
                    "fa-soccer-ball-o",
                    61923
                },

                {
                    "fa-tty",
                    61924
                },

                {
                    "fa-binoculars",
                    61925
                },

                {
                    "fa-plug",
                    61926
                },

                {
                    "fa-slideshare",
                    61927
                },

                {
                    "fa-twitch",
                    61928
                },

                {
                    "fa-yelp",
                    61929
                },

                {
                    "fa-newspaper-o",
                    61930
                },

                {
                    "fa-wifi",
                    61931
                },

                {
                    "fa-calculator",
                    61932
                },

                {
                    "fa-paypal",
                    61933
                },

                {
                    "fa-google-wallet",
                    61934
                },

                {
                    "fa-cc-visa",
                    61936
                },

                {
                    "fa-cc-mastercard",
                    61937
                },

                {
                    "fa-cc-discover",
                    61938
                },

                {
                    "fa-cc-amex",
                    61939
                },

                {
                    "fa-cc-paypal",
                    61940
                },

                {
                    "fa-cc-stripe",
                    61941
                },

                {
                    "fa-bell-slash",
                    61942
                },

                {
                    "fa-bell-slash-o",
                    61943
                },

                {
                    "fa-trash",
                    61944
                },

                {
                    "fa-copyright",
                    61945
                },

                {
                    "fa-at",
                    61946
                },

                {
                    "fa-eyedropper",
                    61947
                },

                {
                    "fa-paint-brush",
                    61948
                },

                {
                    "fa-birthday-cake",
                    61949
                },

                {
                    "fa-area-chart",
                    61950
                },

                {
                    "fa-pie-chart",
                    61952
                },

                {
                    "fa-line-chart",
                    61953
                },

                {
                    "fa-lastfm",
                    61954
                },

                {
                    "fa-lastfm-square",
                    61955
                },

                {
                    "fa-toggle-off",
                    61956
                },

                {
                    "fa-toggle-on",
                    61957
                },

                {
                    "fa-bicycle",
                    61958
                },

                {
                    "fa-bus",
                    61959
                },

                {
                    "fa-ioxhost",
                    61960
                },

                {
                    "fa-angellist",
                    61961
                },

                {
                    "fa-cc",
                    61962
                },

                {
                    "fa-ils",
                    61963
                },

                {
                    "fa-shekel",
                    61963
                },

                {
                    "fa-sheqel",
                    61963
                },

                {
                    "fa-meanpath",
                    61964
                },

                {
                    "fa-buysellads",
                    61965
                },

                {
                    "fa-connectdevelop",
                    61966
                },

                {
                    "fa-dashcube",
                    61968
                },

                {
                    "fa-forumbee",
                    61969
                },

                {
                    "fa-leanpub",
                    61970
                },

                {
                    "fa-sellsy",
                    61971
                },

                {
                    "fa-shirtsinbulk",
                    61972
                },

                {
                    "fa-simplybuilt",
                    61973
                },

                {
                    "fa-skyatlas",
                    61974
                },

                {
                    "fa-cart-plus",
                    61975
                },

                {
                    "fa-cart-arrow-down",
                    61976
                },

                {
                    "fa-diamond",
                    61977
                },

                {
                    "fa-ship",
                    61978
                },

                {
                    "fa-user-secret",
                    61979
                },

                {
                    "fa-motorcycle",
                    61980
                },

                {
                    "fa-street-view",
                    61981
                },

                {
                    "fa-heartbeat",
                    61982
                },

                {
                    "fa-venus",
                    61985
                },

                {
                    "fa-mars",
                    61986
                },

                {
                    "fa-mercury",
                    61987
                },

                {
                    "fa-transgender",
                    61988
                },

                {
                    "fa-intersex",
                    61988
                },

                {
                    "fa-transgender-alt",
                    61989
                },

                {
                    "fa-venus-double",
                    61990
                },

                {
                    "fa-mars-double",
                    61991
                },

                {
                    "fa-venus-mars",
                    61992
                },

                {
                    "fa-mars-stroke",
                    61993
                },

                {
                    "fa-mars-stroke-v",
                    61994
                },

                {
                    "fa-mars-stroke-h",
                    61995
                },

                {
                    "fa-neuter",
                    61996
                },

                {
                    "fa-genderless",
                    61997
                },

                {
                    "fa-facebook-official",
                    62000
                },

                {
                    "fa-pinterest-p",
                    62001
                },

                {
                    "fa-whatsapp",
                    62002
                },

                {
                    "fa-server",
                    62003
                },

                {
                    "fa-user-plus",
                    62004
                },

                {
                    "fa-user-times",
                    62005
                },

                {
                    "fa-bed",
                    62006
                },

                {
                    "fa-hotel",
                    62006
                },

                {
                    "fa-viacoin",
                    62007
                },

                {
                    "fa-train",
                    62008
                },

                {
                    "fa-subway",
                    62009
                },

                {
                    "fa-medium",
                    62010
                },

                {
                    "fa-y-combinator",
                    62011
                },

                {
                    "fa-yc",
                    62011
                },

                {
                    "fa-optin-monster",
                    62012
                },

                {
                    "fa-opencart",
                    62013
                },

                {
                    "fa-expeditedssl",
                    62014
                },

                {
                    "fa-battery-full",
                    62016
                },

                {
                    "fa-battery-4",
                    62016
                },

                {
                    "fa-battery",
                    62016
                },

                {
                    "fa-battery-three-quarters",
                    62017
                },

                {
                    "fa-battery-3",
                    62017
                },

                {
                    "fa-battery-half",
                    62018
                },

                {
                    "fa-battery-2",
                    62018
                },

                {
                    "fa-battery-quarter",
                    62019
                },

                {
                    "fa-battery-1",
                    62019
                },

                {
                    "fa-battery-empty",
                    62020
                },

                {
                    "fa-battery-0",
                    62020
                },

                {
                    "fa-mouse-pointer",
                    62021
                },

                {
                    "fa-i-cursor",
                    62022
                },

                {
                    "fa-object-group",
                    62023
                },

                {
                    "fa-object-ungroup",
                    62024
                },

                {
                    "fa-sticky-note",
                    62025
                },

                {
                    "fa-sticky-note-o",
                    62026
                },

                {
                    "fa-cc-jcb",
                    62027
                },

                {
                    "fa-cc-diners-club",
                    62028
                },

                {
                    "fa-clone",
                    62029
                },

                {
                    "fa-balance-scale",
                    62030
                },

                {
                    "fa-hourglass-o",
                    62032
                },

                {
                    "fa-hourglass-start",
                    62033
                },

                {
                    "fa-hourglass-1",
                    62033
                },

                {
                    "fa-hourglass-half",
                    62034
                },

                {
                    "fa-hourglass-2",
                    62034
                },

                {
                    "fa-hourglass-end",
                    62035
                },

                {
                    "fa-hourglass-3",
                    62035
                },

                {
                    "fa-hourglass",
                    62036
                },

                {
                    "fa-hand-rock-o",
                    62037
                },

                {
                    "fa-hand-grab-o",
                    62037
                },

                {
                    "fa-hand-paper-o",
                    62038
                },

                {
                    "fa-hand-stop-o",
                    62038
                },

                {
                    "fa-hand-scissors-o",
                    62039
                },

                {
                    "fa-hand-lizard-o",
                    62040
                },

                {
                    "fa-hand-spock-o",
                    62041
                },

                {
                    "fa-hand-pointer-o",
                    62042
                },

                {
                    "fa-hand-peace-o",
                    62043
                },

                {
                    "fa-trademark",
                    62044
                },

                {
                    "fa-registered",
                    62045
                },

                {
                    "fa-creative-commons",
                    62046
                },

                {
                    "fa-gg",
                    62048
                },

                {
                    "fa-gg-circle",
                    62049
                },

                {
                    "fa-tripadvisor",
                    62050
                },

                {
                    "fa-odnoklassniki",
                    62051
                },

                {
                    "fa-odnoklassniki-square",
                    62052
                },

                {
                    "fa-get-pocket",
                    62053
                },

                {
                    "fa-wikipedia-w",
                    62054
                },

                {
                    "fa-safari",
                    62055
                },

                {
                    "fa-chrome",
                    62056
                },

                {
                    "fa-firefox",
                    62057
                },

                {
                    "fa-opera",
                    62058
                },

                {
                    "fa-internet-explorer",
                    62059
                },

                {
                    "fa-television",
                    62060
                },

                {
                    "fa-tv",
                    62060
                },

                {
                    "fa-contao",
                    62061
                },

                {
                    "fa-500px",
                    62062
                },

                {
                    "fa-amazon",
                    62064
                },

                {
                    "fa-calendar-plus-o",
                    62065
                },

                {
                    "fa-calendar-minus-o",
                    62066
                },

                {
                    "fa-calendar-times-o",
                    62067
                },

                {
                    "fa-calendar-check-o",
                    62068
                },

                {
                    "fa-industry",
                    62069
                },

                {
                    "fa-map-pin",
                    62070
                },

                {
                    "fa-map-signs",
                    62071
                },

                {
                    "fa-map-o",
                    62072
                },

                {
                    "fa-map",
                    62073
                },

                {
                    "fa-commenting",
                    62074
                },

                {
                    "fa-commenting-o",
                    62075
                },

                {
                    "fa-houzz",
                    62076
                },

                {
                    "fa-vimeo",
                    62077
                },

                {
                    "fa-black-tie",
                    62078
                },

                {
                    "fa-fonticons",
                    62080
                },

                {
                    "fa-reddit-alien",
                    62081
                },

                {
                    "fa-edge",
                    62082
                },

                {
                    "fa-credit-card-alt",
                    62083
                },

                {
                    "fa-codiepie",
                    62084
                },

                {
                    "fa-modx",
                    62085
                },

                {
                    "fa-fort-awesome",
                    62086
                },

                {
                    "fa-usb",
                    62087
                },

                {
                    "fa-product-hunt",
                    62088
                },

                {
                    "fa-mixcloud",
                    62089
                },

                {
                    "fa-scribd",
                    62090
                },

                {
                    "fa-pause-circle",
                    62091
                },

                {
                    "fa-pause-circle-o",
                    62092
                },

                {
                    "fa-stop-circle",
                    62093
                },

                {
                    "fa-stop-circle-o",
                    62094
                },

                {
                    "fa-shopping-bag",
                    62096
                },

                {
                    "fa-shopping-basket",
                    62097
                },

                {
                    "fa-hashtag",
                    62098
                },

                {
                    "fa-bluetooth",
                    62099
                },

                {
                    "fa-bluetooth-b",
                    62100
                },

                {
                    "fa-percent",
                    62101
                },

                {
                    "fa-gitlab",
                    62102
                },

                {
                    "fa-wpbeginner",
                    62103
                },

                {
                    "fa-wpforms",
                    62104
                },

                {
                    "fa-envira",
                    62105
                },

                {
                    "fa-universal-access",
                    62106
                },

                {
                    "fa-wheelchair-alt",
                    62107
                },

                {
                    "fa-question-circle-o",
                    62108
                },

                {
                    "fa-blind",
                    62109
                },

                {
                    "fa-audio-description",
                    62110
                },

                {
                    "fa-volume-control-phone",
                    62112
                },

                {
                    "fa-braille",
                    62113
                },

                {
                    "fa-assistive-listening-systems",
                    62114
                },

                {
                    "fa-american-sign-language-interpreting",
                    62115
                },

                {
                    "fa-asl-interpreting",
                    62115
                },

                {
                    "fa-deaf",
                    62116
                },

                {
                    "fa-deafness",
                    62116
                },

                {
                    "fa-hard-of-hearing",
                    62116
                },

                {
                    "fa-glide",
                    62117
                },

                {
                    "fa-glide-g",
                    62118
                },

                {
                    "fa-sign-language",
                    62119
                },

                {
                    "fa-signing",
                    62119
                },

                {
                    "fa-low-vision",
                    62120
                },

                {
                    "fa-viadeo",
                    62121
                },

                {
                    "fa-viadeo-square",
                    62122
                },

                {
                    "fa-snapchat",
                    62123
                },

                {
                    "fa-snapchat-ghost",
                    62124
                },

                {
                    "fa-snapchat-square",
                    62125
                },

                {
                    "fa-pied-piper",
                    62126
                },

                {
                    "fa-first-order",
                    62128
                },

                {
                    "fa-yoast",
                    62129
                },

                {
                    "fa-themeisle",
                    62130
                },

                {
                    "fa-google-plus-official",
                    62131
                },

                {
                    "fa-google-plus-circle",
                    62131
                },

                {
                    "fa-font-awesome",
                    62132
                },

                {
                    "fa-fa",
                    62132
                },

                {
                    "fa-handshake-o",
                    62133
                },

                {
                    "fa-envelope-open",
                    62134
                },

                {
                    "fa-envelope-open-o",
                    62135
                },

                {
                    "fa-linode",
                    62136
                },

                {
                    "fa-address-book",
                    62137
                },

                {
                    "fa-address-book-o",
                    62138
                },

                {
                    "fa-address-card",
                    62139
                },

                {
                    "fa-vcard",
                    62139
                },

                {
                    "fa-address-card-o",
                    62140
                },

                {
                    "fa-vcard-o",
                    62140
                },

                {
                    "fa-user-circle",
                    62141
                },

                {
                    "fa-user-circle-o",
                    62142
                },

                {
                    "fa-user-o",
                    62144
                },

                {
                    "fa-id-badge",
                    62145
                },

                {
                    "fa-id-card",
                    62146
                },

                {
                    "fa-drivers-license",
                    62146
                },

                {
                    "fa-id-card-o",
                    62147
                },

                {
                    "fa-drivers-license-o",
                    62147
                },

                {
                    "fa-quora",
                    62148
                },

                {
                    "fa-free-code-camp",
                    62149
                },

                {
                    "fa-telegram",
                    62150
                },

                {
                    "fa-thermometer-full",
                    62151
                },

                {
                    "fa-thermometer-4",
                    62151
                },

                {
                    "fa-thermometer",
                    62151
                },

                {
                    "fa-thermometer-three-quarters",
                    62152
                },

                {
                    "fa-thermometer-3",
                    62152
                },

                {
                    "fa-thermometer-half",
                    62153
                },

                {
                    "fa-thermometer-2",
                    62153
                },

                {
                    "fa-thermometer-quarter",
                    62154
                },

                {
                    "fa-thermometer-1",
                    62154
                },

                {
                    "fa-thermometer-empty",
                    62155
                },

                {
                    "fa-thermometer-0",
                    62155
                },

                {
                    "fa-shower",
                    62156
                },

                {
                    "fa-bath",
                    62157
                },

                {
                    "fa-bathtub",
                    62157
                },

                {
                    "fa-s15",
                    62157
                },

                {
                    "fa-podcast",
                    62158
                },

                {
                    "fa-window-maximize",
                    62160
                },

                {
                    "fa-window-minimize",
                    62161
                },

                {
                    "fa-window-restore",
                    62162
                },

                {
                    "fa-window-close",
                    62163
                },

                {
                    "fa-times-rectangle",
                    62163
                },

                {
                    "fa-window-close-o",
                    62164
                },

                {
                    "fa-times-rectangle-o",
                    62164
                },

                {
                    "fa-bandcamp",
                    62165
                },

                {
                    "fa-grav",
                    62166
                },

                {
                    "fa-etsy",
                    62167
                },

                {
                    "fa-imdb",
                    62168
                },

                {
                    "fa-ravelry",
                    62169
                },

                {
                    "fa-eercast",
                    62170
                },

                {
                    "fa-microchip",
                    62171
                },

                {
                    "fa-snowflake-o",
                    62172
                },

                {
                    "fa-superpowers",
                    62173
                },

                {
                    "fa-wpexplorer",
                    62174
                },

                {
                    "fa-meetup",
                    62176
                }
            };
            FontAwesome.Init();
        }
        public unsafe static void Init()
        {
            FontAwesome.Top = 0;
            FontAwesome.Left = 0;
            FontAwesome.IconSize = 128;
            FontAwesome.BorderVisible = false;
            FontAwesome.BackColer = Color.Transparent;
            FontAwesome.ForeColer = Color.Black;
            FontAwesome.BorderColer = Color.Gray;
            string text = FontAwesome.FontAwesomeLocation + FontAwesome.FontAwesomeName;
            try
            {
                try
                {
                    fixed (byte* ptr = Resources.fontawesome_webfont)
                    {
                        FontAwesome.FontCollection.AddMemoryFont((IntPtr)((void*)ptr), Resources.fontawesome_webfont.Length);
                    }
                }
                finally
                {
                    byte* ptr = null;
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// get FontAwesome icon
        /// </summary>
        /// <param name="iconText">FontAwesome icon hex code</param>
        /// <returns></returns>
        public static Icon GetIcon(int iconText)
        {
            Bitmap image = FontAwesome.GetImage(iconText);
            bool flag = image != null;
            Icon result;
            if (flag)
            {
                result = FontAwesome.ToIcon(image, FontAwesome.IconSize);
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static Icon GetIcon(FaEnum emu)
        {
            Bitmap image = FontAwesome.GetImage(emu);
            bool flag = image != null;
            Icon result;
            if (flag)
            {
                result = FontAwesome.ToIcon(image, FontAwesome.IconSize);
            }
            else
            {
                result = null;
            }
            return result;
        }
        public static Bitmap GetImage(FaEnum emu)
        {
            return FontAwesome.GetImage((int)emu);
        }
        /// <summary>
        /// get FontAwesome image
        /// </summary>
        /// <param name="iconText">FontAwesome icon hex code</param>
        /// <returns></returns>
        public static Bitmap GetImage(int iconText)
        {
            Size iconSize = FontAwesome.GetIconSize(iconText);
            Bitmap bitmap = new Bitmap(iconSize.Width, iconSize.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                string s = char.ConvertFromUtf32(iconText);
                Font font = FontAwesome.GetFont();
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                Rectangle rect = new Rectangle(new Point(0, 0), iconSize);
                Brush brush = new SolidBrush(FontAwesome.BackColer);
                graphics.FillRectangle(brush, rect);
                brush.Dispose();
                Brush brush2 = new SolidBrush(FontAwesome.ForeColer);
                PointF point = new PointF((float)FontAwesome.Left, (float)FontAwesome.Top);
                graphics.DrawString(s, font, brush2, point);
                brush2.Dispose();
                graphics.DrawImage(bitmap, 0, 0);
            }
            return bitmap;
        }
        /// <summary>
        /// get icon really size
        /// </summary>
        /// <param name="iconText">FontAwesome icon hex code</param>
        /// <returns></returns>
        private static Size GetIconSize(int iconText)
        {
            Size result;
            using (Bitmap bitmap = new Bitmap(FontAwesome.IconSize, FontAwesome.IconSize))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    string text = char.ConvertFromUtf32(iconText);
                    Font font = FontAwesome.GetFont();
                    result = graphics.MeasureString(text, font).ToSize();
                }
            }
            return result;
        }
        /// <summary>
        /// image resizer funtion
        /// </summary>
        /// <param name="srcImage">source Bitmap object</param>
        /// <param name="destSize">dest image's size</param>
        /// <param name="offset">dest image offset point</param>
        /// <param name="backColor">dest image's background color,default value is <value>Color.Transparent</value></param>
        /// <param name="drawBorder">dest image's size</param>
        /// <param name="borderColor">dest image's border color,default value is Color.Gray</param>
        /// <returns></returns>
        private static Bitmap Resizer(Bitmap srcImage, Size destSize, Point offset, Color backColor, bool drawBorder, Color borderColor)
        {
            bool flag = srcImage == null;
            if (flag)
            {
                throw new ArgumentNullException("srcImage");
            }
            Bitmap bitmap = new Bitmap(destSize.Width, destSize.Height);
            Bitmap result;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                Size size = srcImage.Size;
                int num = Math.Max(size.Height, size.Width);
                int width = num;
                int height = num;
                int x = (size.Width - num) / 2 - offset.X;
                int y = (size.Height - num) / 2 - offset.Y;
                Rectangle rectangle = new Rectangle(new Point(0, 0), bitmap.Size);
                Rectangle srcRect = new Rectangle(x, y, width, height);
                Brush brush = new SolidBrush(backColor);
                graphics.FillRectangle(brush, rectangle);
                brush.Dispose();
                graphics.DrawImage(srcImage, rectangle, srcRect, GraphicsUnit.Pixel);
                if (drawBorder)
                {
                    Pen pen = new Pen(borderColor);
                    graphics.DrawRectangle(pen, rectangle);
                    pen.Dispose();
                }
                result = bitmap;
            }
            return result;
        }
        /// <summary>
        /// convert image to icon
        /// </summary>
        /// <param name="srcBitmap">The input stream</param>
        /// <param name="size">The size (16x16 px by default)</param>
        /// <returns>Icon</returns>
        private static Icon ToIcon(Bitmap srcBitmap, int size)
        {
            bool flag = srcBitmap == null;
            if (flag)
            {
                throw new ArgumentNullException("srcBitmap");
            }
            Icon result = null;
            Bitmap bitmap = new Bitmap(srcBitmap, new Size(size, size));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Png);
                Stream stream = new MemoryStream();
                BinaryWriter binaryWriter = new BinaryWriter(stream);
                binaryWriter.Write(0);
                binaryWriter.Write(0);
                binaryWriter.Write(1);
                binaryWriter.Write(1);
                binaryWriter.Write((byte)size);
                binaryWriter.Write((byte)size);
                binaryWriter.Write(0);
                binaryWriter.Write(0);
                binaryWriter.Write(0);
                binaryWriter.Write(32);
                binaryWriter.Write((int)memoryStream.Length);
                binaryWriter.Write(22);
                binaryWriter.Write(memoryStream.ToArray());
                binaryWriter.Flush();
                binaryWriter.Seek(0, SeekOrigin.Begin);
                result = new Icon(stream);
                stream.Dispose();
            }
            return result;
        }
        /// <summary>
        /// get font function
        /// </summary>
        /// <returns></returns>
        private static Font GetFont()
        {
            float emSize = (float)FontAwesome.IconSize * 0.75f;
            return new Font(FontAwesome.FontCollection.Families[0], emSize, GraphicsUnit.Point);
        }
        [DllImport("gdi32")]
        private static extern IntPtr CreateFont(int H, int W, int E, int O, int FW, int I, int u, int S, int C, int OP, int CP, int Q, int PAF, string F);
        private static Font CreateFont()
        {
            float num = (float)FontAwesome.IconSize * 0.75f;
            IntPtr hfont = FontAwesome.CreateFont(20, 20, 0, 0, 200, 1, 0, 0, 0, 0, 0, 0, 32, "宋体");
            return Font.FromHfont(hfont);
        }
    }
}
