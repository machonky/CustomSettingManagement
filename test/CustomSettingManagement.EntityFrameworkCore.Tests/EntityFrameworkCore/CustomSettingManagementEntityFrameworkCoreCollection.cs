﻿using Xunit;

namespace CustomSettingManagement.EntityFrameworkCore;

[CollectionDefinition(CustomSettingManagementTestConsts.CollectionDefinitionName)]
public class CustomSettingManagementEntityFrameworkCoreCollection : ICollectionFixture<CustomSettingManagementEntityFrameworkCoreFixture>
{

}