# Contributing to this project

Collaboration is currently restricted to project members only. Feel free to ask (via e-mail) for an invitation to be added to the project as a collaborator!

Note that you will be required to contribute! It is not OK to just ask for documentation, ask usage questions, or report bugs and expect that someone else will fix them for you &ndash; if you need something from this project, you are expected to also give something back to it!


## Asking usage questions (as an issue or discussion)

This repository's focus is on the development of the library (i.e. fixing bugs, as well as improving features and the documentation). Because the team is rather small, our resources to answer usage questions is very limited. You might be better off asking usage questions over at [Stack Overflow](https://stackoverflow.com) as your question will meet with a much larger audience. Please observe SO's rules and etiquette.

**What will be expected of you:** If you choose to ask a question at this repository, you should contribute to the project (e.g. by improving the documentation accordingly) once your question has been answered by other members.


## Submitting a bug report (as an issue)

If you think you've found a bug, please start by searching [the changelog](https://github.com/stakx/moq/blob/v4/CHANGELOG.md) and existing issues at [this fork's issue tracker](https://github.com/stakx/moq/issues) and at [the parent project's issue tracker](https://github.com/moq/moq/issues) (both open and closed ones!) to see if the problem has already been addressed or documented in any way.

If you find nothing of relevance at this repository, [open a new issue](https://github.com/stakx/moq/issues/new).


**What to include:** Try to include the following information in it:

 * a brief summary
 * minimal, complete, and verifiable repro code (similar to what you'd have to prepare for a Stack Overflow question; see e.g. [their documentation on "How to create a Minimal, Complete, and Verifiable example"](https://stackoverflow.com/help/mcve)
 * a description of the expected (correct) outcome
 * a description of the actual (incorrect) outcome
 * Moq version used


**What will be expected of you:** Please do not expect other project members to fix the bug for you, and that you can simply be on your merry way once a new version of the library has been published. Ideally, you're going to help us fix this bug! Since you might not know the code base well enough for that, other project members (especially maintainers) are there to help you get familiar with the code, as well as to point out how the bug could be fixed. If you still don't feel up to the task, you are encouraged to contribute to the project in some other meaningful way.


## Submitting a pull request (PR)

Unless for very simple and straightforward changes, please open an issue first to discuss the PR you're about to submit.


**What to include:** Once you do submit a PR, please include the following:

 * Unit tests whenever you add a bug fix, new feature, or when you change an existing one.

 * All changes relevant to Moq users should be documented in the `CHANGELOG.md`. Please describe your change or bug fix in that file (more specifically under the _Unreleased_ heading at the beginning of it). Phrase the summary in a way that it will be easily understandable and useful to other Moq users.

   ```diff
    # Unreleased
    
    ...
    
    #### Fixed
    
   +* <Short explanation of the bug fix> (@<your username>, #<issue or PR number>)
   ```

   Note the inclusion of your user name and a reference to the relevant PR or issue. The former is included to give you credit for your contribution. The latter allows users to trace the history of a change back to the issue where it was first reported.


**Structuring your PR commits (example):** One good way, but not the only one, of structuring your PR might be to follow a test-first approach:

 1. Start with a commit that adds one or more failing unit tests.

 2. Add one or more commits that make these unit tests pass.

 3. Add a final commit with a new changelog entry.

Of course, if your changes are small, you might combine all these steps into fewer or even a single commit.


**When a reviewer requests changes to your PR,** we encourage (but don't require) you to keep your PR tidy using any Git facilities available: You can rewrite your PR branch's history by amending existing commits, rebasing, etc., then force-pushing the changed commits to your PR branch. If you are not familiar enough with Git to do all of this, simply adding more commits to make requested changes is fine. A Moq team member merging your PR may decide to "squash" them into a single commit to keep the repository's history more easily readable.


## Code style rules

**Indentation, line endings, etc.**: The project includes a [`.editorconfig`](https://editorconfig.org/) file. Please make sure your IDE can read this file so that indentation, line endings, etc. is kept consistent across the whole code base. When submitting a PR, try to keep your commit diffs free of whitespace-only changes.


**Copyright notice:** Please ensure that each code file added or changed by you begins with the following copyright notice:

```csharp
// Copyright (c) 2007, Clarius Consulting, Manas Technology Solutions, InSTEDD, and Contributors.
// Copyright (c) 2023 stakx and contributors.
// All rights reserved. Licensed under the BSD 3-Clause License; see License.txt.
```


**.NET code conventions:** The Moq codebase follows the usual .NET code conventions as documented e.g. in [Framework Design Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/); so following the existing conventions should be no big issue when adding new code.
