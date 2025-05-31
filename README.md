# PR Code Review with OpenAI GPT

This GitHub Action automates code reviews for pull requests using OpenAI's GPT models. When a pull request is opened or updated against the `main` branch, the workflow generates a diff of the changes, sanitizes it, and sends it to an OpenAI model for review. The generated review is then posted as a comment on the pull request.

## Features

- **Automated Code Review:** Uses OpenAI GPT models (e.g., `gpt-4o-mini`, `gpt-4`, `gpt-3.5-turbo`) to review code changes.
- **Diff Sanitization:** Only relevant code changes are sent to the model, with metadata and large diffs trimmed for efficiency.
- **PR Commenting:** Posts the AI-generated review directly to the pull request as a comment.
- **Job Summary:** Adds a summary of the review process to the workflow run.

## Usage

1. **Fork or clone this repository.**
2. **Set up the required secrets:**
   - `OPENAI_API_KEY`: Your OpenAI API key.
   - `GITHUB_TOKEN`: Provided by GitHub Actions by default.

3. **Customize the workflow:**
   - Edit `.github/workflows/code-review.yml` to change the model or adjust diff limits as needed.

4. **Open or update a pull request targeting the `main` branch.**
   - The workflow will trigger automatically and post a review comment.

## Workflow Overview

1. **Checkout Repository:** Fetches all branches and history.
2. **Generate Diff:** Compares the base and head branches to create a diff file.
3. **Sanitize Diff:** Filters out metadata, keeping only code changes.
4. **Prepare Prompt:** Formats the diff and instructions for the GPT model.
5. **OpenAI Review:** Sends the prompt to OpenAI and retrieves the review.
6. **Post Review:** Comments the review on the pull request.
7. **Job Summary:** Updates the workflow summary with the review status.

## Requirements

- GitHub repository with Actions enabled.
- OpenAI API access.

## Customization

- **Model Selection:** Change the `MODEL_NAME` environment variable in the workflow file.
- **Diff Size:** Adjust the number of lines sent to the model by modifying the `head -200` command.

## License

This project is licensed under the MIT License.
