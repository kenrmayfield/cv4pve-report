/*
 * SPDX-FileCopyrightText: Copyright Corsinvest Srl
 * SPDX-License-Identifier: GPL-3.0-only
 */

namespace Corsinvest.ProxmoxVE.Report;

/// <summary>
/// Disk-related settings for node detail sheet
/// </summary>
public class SettingsDisk
{
    /// <summary>
    /// Include physical disk list
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Include SMART health data per disk (one API call per disk)
    /// </summary>
    public bool IncludeSmartData { get; set; }

    /// <summary>
    /// Include ZFS pool status and vdev tree
    /// </summary>
    public bool IncludeZfs { get; set; } = true;

    /// <summary>
    /// Include directory mount points
    /// </summary>
    public bool IncludeDirectory { get; set; } = true;
}
