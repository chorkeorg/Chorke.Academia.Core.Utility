# [Chorke.Academia.Core.Utility][201]

It's a Dotnet core project of [Chorke, Inc.][000] and a Nuget `nupkg`. This is the class library project of [Chorke, Inc.][000]'s future projects. It will be package as `nupkg`. All the dependent child projects of the [Chorke.Academia.Core.Utility][201] are able to access as dependency by following:


```xml
<dependencies>
    <dependency id="Chorke.Academia.Core.Utility" version="1.0.0" />
</dependencies>
```


All of the resources and libraries of [Chorke, Inc.][000] permitted to use under considering `MIT` license. Clone project using Git Source Control Manager:

1. [`git clone bit.chorke.org:chorkeorg/Chorke.Academia.Core.Utility.git`][201] from [bit.chorke.org][200]
2. [`git clone git.chorke.org:chorkeorg/Chorke.Academia.Core.Utility.git`][301] from [git.chorke.org][300]


### upload `rsa` keys then add to `~/.ssh/config`

```cfg
Host bit.chorke.org
     HostName bitbucket.org
     PreferredAuthentications publickey
     IdentityFile ~/.ssh/bit_chorke_rsa
     User git

Host git.chorke.org
     HostName github.com
     PreferredAuthentications publickey
     IdentityFile ~/.ssh/git_chorke_rsa
     User git
     
```


### build single modules by shell

```bash
\
dotnet publish Chorke.Academia.Core.Utility &&\
dotnet test Chorke.Academia.Core.Utility.Tests &&\
cd Chorke.Academia.Core.Utility &&\
dotnet pack -c Release /p:PackageVersion=1.0.0 && cd bin/Release &&\
dotnet nuget push Chorke.Academia.Core.Utility.1.0.0.nupkg \
-k oy2dxmxzpdrjded5hs6qfoykefocyezernxwnz2plppgea \
-s https://www.nuget.org/ &&
cd ../../..

\
dotnet publish Chorke.Academia.Core.Utility &&\
dotnet test Chorke.Academia.Core.Utility.Tests &&\
cd Chorke.Academia.Core.Utility &&\
dotnet pack -c Release /p:PackageVersion=1.0.0 && cd bin/Release &&\
nuget update Chorke.Academia.Core.Utility.1.0.0.nupkg -Source \
https://www.nuget.org/ -apikey oy2dxmxzpdrjded5hs6qfoykefocyezernxwnz2plppgea \
&& cd ../../..

\
nuget delete Chorke.Academia.Core.Utility 1.0.0 -Source \
https://www.nuget.org/ -apikey oy2dxmxzpdrjded5hs6qfoykefocyezernxwnz2plppgea

\
nuget setApiKey oy2dxmxzpdrjded5hs6qfoykefocyezernxwnz2plppgea \
-Source https://www.nuget.org/

```


### good to know for git and shell

```bash
# good to know for run ssh agent
eval "$(ssh-agent -s)"
ssh-add -K ~/.ssh/bit_chorke_rsa
ssh-add -K ~/.ssh/git_chorke_rsa

# good to know for delete commit
git reset --hard HEAD^
git push --force

# good to know for delete gittag
git push --delete origin tagname
git tag  --delete tagname

# good to know before git ignore
git rm --cached to/file/path/name.*
git rm --cached to/file/path/name.ext

# good to know git stop tracking
git update-index --assume-unchanged to/file/path/name.*
git update-index --assume-unchanged to/file/path/name.ext

# good to know for find and replace
for f in $(find ./dirname/ -name '*.cs'); do sed "s/init/ebis/g" \
"$f"> "$f.tmp" && mv "$f.tmp" "$f"; done;

```


### nuget feed repository config for `~/.nuget/NuGet/NuGet.Config`

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
  </packageSources>
</configuration>
```


### LICENSE

```
Copyright (c) 2013-2019 Chorke Academia, Inc.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```


### About the Project

Actually it's not a complete project, it's can be best defined as library. While this project started aim to build the foundation/skeleton of enterprise graded project. Base on this foundation/skeleton any one can able to build enterprise application. This library/foundation/skeleton project will reduce the learning curve and maximized the productivity.


### About [Chorke, Inc.][100]

[`Chorke, Inc.`][000] founded aimed to develop `Open Source Enterprise Graded Application`, based on `Java`, `Dotnet`, `JavaScript`, `Ruby`, `Python` and `PHP`. Integrated, Modularized, Simplified and loosely coupled application development is our vision. Our goal is minimize the learning curve, maximizing the productivity using `Open Source` technology. Trying the best practice to transparent and enrich software development using `OOP(Object Oriented Programming)`. Our development process accelerated by `XP (Extreme Programming)` and Agile Scrum Master. While it's reduce the time and costing.


### About Founder

**Md Shahed Hossain**, **Rashida Akter** is the co-founder of [`Chorke, Inc.`][000] and **Raiyan Bin Shahed** is the next successor. Mr. **Shahed** is an enthusiastic java developer and open source community leader. Mrs. **Rushi** is his lady and **Raiyan** is their elder son. Who are the part of inspiration, innovation and contribution to [`Chorke, Inc.`][001].


### Contact

- [**devs@chorke.com**][100]
- [**devs@chorke.org**][101]
- [**www.chorke.com**][000]
- [**www.chorke.org**][001]


[000]:  http://chorke.com "Chorke, Inc. Visit us"
[001]:  http://chorke.org "Chorke, Org. Visit us"

[100]:  mailto:devs@chorke.com "Chorke, Inc. Email us"
[101]:  mailto:devs@chorke.org "Chorke, Org. Email us"

[200]:  https://bitbucket.org/chorkeorg "bit.chorke.org"
[201]:  https://bitbucket.org/chorkeorg/Chorke.Academia.Core.Utility "Chorke.Academia.Core.Utility"

[300]:  https://github.com/chorkeorg "git.chorke.org"
[301]:  https://github.com/chorkeorg/Chorke.Academia.Core.Utility "Chorke.Academia.Core.Utility"
