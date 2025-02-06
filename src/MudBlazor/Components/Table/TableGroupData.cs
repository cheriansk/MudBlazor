// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace MudBlazor;

#nullable enable

/// <summary>
/// The data within a <see cref="MudTable{T}"/> group when grouping is enabled.
/// </summary>
/// <typeparam name="TKey">The unique key of this group.</typeparam>
/// <typeparam name="TElement">The type of data within this group.</typeparam>
public class TableGroupData<TKey, TElement>
{
    /// <summary>
    /// The label of this group.
    /// </summary>
    public string? GroupName { get; }
    public string? GroupHeader_Ext { get; set; }
    public string? Id_Ext { get; set; }
    public bool? IsLinked_Ext { get; set; }

    /// <summary>
    /// The unique key of this group.
    /// </summary>
    public TKey? Key { get; }

    /// <summary>
    /// The data rows for this group.
    /// </summary>
    public IEnumerable<TElement> Items { get; }

    /// <summary>
    /// Creates a new instance.
    /// </summary>
    /// <param name="groupName">The label of this group.</param>
    /// <param name="key">The unique key of this group.</param>
    /// <param name="items">The data rows for this group.</param>
    /// <param name="groupHeader_Ext">head description.</param>
    /// <param name="id_Ext">Unique Id for the row.</param>
    /// <param name="isLinked_Ext">If this row is linked to another or not.</param>
    public TableGroupData(string? groupName, TKey? key, IEnumerable<TElement> items, string? groupHeader_Ext,string? id_Ext, bool? isLinked_Ext)
    {
        GroupName = groupName;
        Key = key;
        Items = items;
        GroupHeader_Ext = groupHeader_Ext;
        Id_Ext = id_Ext;
        IsLinked_Ext = isLinked_Ext;

    }
}
